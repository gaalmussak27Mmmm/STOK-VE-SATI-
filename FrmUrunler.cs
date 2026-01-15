using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Stok_ve_Satış.DAL;

namespace Stok_ve_Satış
{
    public partial class FrmUrunler : Form
    {
        public FrmUrunler() { InitializeComponent(); }

        private void FrmUrunler_Load(object sender, EventArgs e)
        {
            UrunleriListele();
            if (dgvUrunler != null)
            {
                dgvUrunler.BackgroundColor = System.Drawing.Color.White;
                dgvUrunler.BorderStyle = BorderStyle.None;
                dgvUrunler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvUrunler.RowHeadersVisible = false;
            }
        }

        private void UrunleriListele()
        {
            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT Id, ProductName, SalePrice, StockQuantity FROM Products", baglan);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvUrunler.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Liste Hatası: " + ex.Message); }
        }

        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            // BOŞ KUTU KONTROLÜ
            if (string.IsNullOrEmpty(txtUrunAd.Text) || string.IsNullOrEmpty(txtSatisFiyat.Text))
            {
                MessageBox.Show("Lütfen ürün adı ve fiyat alanlarını doldurun!");
                return;
            }

            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();
                    string sql = "INSERT INTO Products (ProductName, SalePrice, StockQuantity) VALUES (@p1, @p2, @p3)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, baglan))
                    {
                        cmd.Parameters.AddWithValue("@p1", txtUrunAd.Text);
                        cmd.Parameters.AddWithValue("@p2", Convert.ToDecimal(txtSatisFiyat.Text));
                        cmd.Parameters.AddWithValue("@p3", Convert.ToInt32(txtStok.Text));
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Ürün başarıyla eklendi.");
                    UrunleriListele();
                }
            }
            catch (Exception ex) { MessageBox.Show("Kaydetme Hatası: " + ex.Message); }
        }

        // 2. CLICK: GÜNCELLE (HATA ÖNLEYİCİ EKLENDİ)
        private void btnUrunGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvUrunler.CurrentRow == null) return;

            try
            {
                // 1. Hücrelerdeki verileri güvenli şekilde al
                object cellId = dgvUrunler.CurrentRow.Cells["Id"].Value;
                object cellName = dgvUrunler.CurrentRow.Cells["ProductName"].Value;
                object cellPrice = dgvUrunler.CurrentRow.Cells["SalePrice"].Value;
                object cellStock = dgvUrunler.CurrentRow.Cells["StockQuantity"].Value;

                // 2. Boş veri kontrolü
                if (cellName == null || cellPrice == null || cellStock == null)
                {
                    MessageBox.Show("Tablodaki alanlar boş olamaz!");
                    return;
                }

                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();
                    string sql = "UPDATE Products SET ProductName=@p1, SalePrice=@p2, StockQuantity=@p3 WHERE Id=@id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, baglan))
                    {
                        cmd.Parameters.AddWithValue("@p1", cellName.ToString());
                        // Sayısal dönüşümlerde hata payını sıfırlıyoruz
                        cmd.Parameters.AddWithValue("@p2", Convert.ToDecimal(cellPrice));
                        cmd.Parameters.AddWithValue("@p3", Convert.ToInt32(cellStock));
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(cellId));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Değişiklikler Kaydedildi!");
                        UrunleriListele();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kaydetme sırasında bir hata oluştu: " + ex.Message);
            }
        }
        private void btnUrunCopKutusu_Click(object sender, EventArgs e)
        {
            FrmUrunCopKutusu copForm = new FrmUrunCopKutusu();
            copForm.ShowDialog();
            UrunleriListele();
        }

        private void dgvUrunler_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void dgvUrunler_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Hata kutusunun çıkmasını engeller, kullanıcı yazmaya devam edebilir.
            e.ThrowException = false;
        }
    }
}