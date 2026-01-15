using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Stok_ve_Satış.DAL;
using ClosedXML.Excel;
using System.IO;

namespace Stok_ve_Satış
{
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            RaporlariGetir(false);
        }

        private void RaporlariGetir(bool filtrele)
        {
            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();

                    string sqlListe = @"SELECT 
                        s.Id, 
                        c.FullName AS 'Müşteri', 
                        p.ProductName AS 'Ürün', 
                        s.SaleDate AS 'Tarih', 
                        (sd.Quantity * sd.UnitPrice) AS 'Tutar'
                    FROM Sales s 
                    INNER JOIN Customers c ON s.CustomerId = c.Id
                    INNER JOIN SalesDetails sd ON s.Id = sd.SaleId
                    INNER JOIN Products p ON sd.ProductId = p.Id";

                    if (filtrele)
                    {
                        sqlListe += " WHERE s.SaleDate BETWEEN @t1 AND @t2";
                    }

                    sqlListe += " ORDER BY s.SaleDate DESC";

                    MySqlCommand cmd = new MySqlCommand(sqlListe, baglan);
                    if (filtrele)
                    {
                        cmd.Parameters.AddWithValue("@t1", dtpBaslangic.Value.ToString("yyyy-MM-dd 00:00:00"));
                        cmd.Parameters.AddWithValue("@t2", dtpBitis.Value.ToString("yyyy-MM-dd 23:59:59"));
                    }

                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvRapor.DataSource = dt;

                    decimal toplamCiro = 0;
                    foreach (DataRow row in dt.Rows)
                    {
                        if (row["Tutar"] != DBNull.Value)
                        {
                            toplamCiro += Convert.ToDecimal(row["Tutar"]);
                        }
                    }

                    lblToplamSatis.Text = "Toplam Satış: " + dt.Rows.Count.ToString();
                    lblToplamCiro.Text = "Toplam Ciro: " + toplamCiro.ToString("C2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rapor hatası: " + ex.Message);
            }
        }

        public void btnFiltrele_Click(object sender, EventArgs e)
        {
            RaporlariGetir(true);
        }

        public void btnYenile_Click(object sender, EventArgs e)
        {
            RaporlariGetir(false);
        }

        public void btnExcelAktar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRapor.Rows.Count == 0)
                {
                    MessageBox.Show("Listede aktarılacak veri bulunamadı.");
                    return;
                }

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("SatisRaporu");
                    worksheet.Cell(1, 1).Value = "Satış Raporu";
                    worksheet.Cell(2, 1).InsertTable((DataTable)dgvRapor.DataSource);

                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Excel Dosyası|*.xlsx";
                    sfd.FileName = "Satis_Raporu_" + DateTime.Now.ToString("ddMMyyyy");

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Excel başarıyla oluşturuldu.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Excel Hatası: " + ex.Message);
            }
        }

        public void btnSatisSil_Click(object sender, EventArgs e)
        {
            if (dgvRapor.CurrentRow == null) return;

            DialogResult onay = MessageBox.Show("Bu kayıt Çöp Kutusu'na taşınacak. Onaylıyor musunuz?", "Çöpe At", MessageBoxButtons.YesNo);
            if (onay == DialogResult.Yes)
            {
                try
                {
                    int id = Convert.ToInt32(dgvRapor.CurrentRow.Cells["Id"].Value);
                    string musteri = dgvRapor.CurrentRow.Cells["Müşteri"].Value.ToString();
                    string urun = dgvRapor.CurrentRow.Cells["Ürün"].Value.ToString();
                    DateTime tarih = Convert.ToDateTime(dgvRapor.CurrentRow.Cells["Tarih"].Value);
                    decimal tutar = Convert.ToDecimal(dgvRapor.CurrentRow.Cells["Tutar"].Value);

                    using (MySqlConnection baglan = Baglanti.GetConnection())
                    {
                        if (baglan.State == ConnectionState.Closed) baglan.Open();

                        // 1. ADIM: Çöp kutusuna (DeletedSales) kopyala
                        string sqlCop = "INSERT INTO DeletedSales (Id, CustomerName, ProductName, SaleDate, TotalAmount, DeletionDate) VALUES (@id, @m, @u, @t, @tutar, @silTarih)";
                        MySqlCommand cmdCop = new MySqlCommand(sqlCop, baglan);
                        cmdCop.Parameters.AddWithValue("@id", id);
                        cmdCop.Parameters.AddWithValue("@m", musteri);
                        cmdCop.Parameters.AddWithValue("@u", urun);
                        cmdCop.Parameters.AddWithValue("@t", tarih);
                        cmdCop.Parameters.AddWithValue("@tutar", tutar);
                        cmdCop.Parameters.AddWithValue("@silTarih", DateTime.Now);
                        cmdCop.ExecuteNonQuery();

                        // 2. ADIM: Orijinal tablolardan sil
                        string sqlDetay = "DELETE FROM SalesDetails WHERE SaleId = @id";
                        MySqlCommand cmd1 = new MySqlCommand(sqlDetay, baglan);
                        cmd1.Parameters.AddWithValue("@id", id);
                        cmd1.ExecuteNonQuery();

                        string sqlSatis = "DELETE FROM Sales WHERE Id = @id";
                        MySqlCommand cmd2 = new MySqlCommand(sqlSatis, baglan);
                        cmd2.Parameters.AddWithValue("@id", id);
                        cmd2.ExecuteNonQuery();

                        MessageBox.Show("Satış çöpe taşındı.");
                        RaporlariGetir(false);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        public void btnCopKutusu_Click(object sender, EventArgs e)
        {
            FrmCopKutusu frm = new FrmCopKutusu();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmSatisCopKutusu frm = new FrmSatisCopKutusu();
            frm.ShowDialog();
        }
    } // class sonu
} // namespace sonu