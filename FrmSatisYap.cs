using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Stok_ve_Satış.DAL;

namespace Stok_ve_Satış
{
    public partial class FrmSatisYap : Form
    {
        public FrmSatisYap()
        {
            InitializeComponent();
        }

        private void FrmSatisYap_Load(object sender, EventArgs e)
        {
            VerileriYukle();
        }

        private void VerileriYukle()
        {
            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();

                    // Müşteri listesi
                    MySqlDataAdapter daMusteri = new MySqlDataAdapter("SELECT Id, FullName FROM Customers", baglan);
                    DataTable dtMusteri = new DataTable();
                    daMusteri.Fill(dtMusteri);
                    cmbMusteri.DataSource = dtMusteri;
                    cmbMusteri.DisplayMember = "FullName";
                    cmbMusteri.ValueMember = "Id";

                    // Ürün listesi
                    MySqlDataAdapter daUrun = new MySqlDataAdapter("SELECT Id, ProductName FROM Products", baglan);
                    DataTable dtUrun = new DataTable();
                    daUrun.Fill(dtUrun);
                    cmbUrun.DataSource = dtUrun;
                    cmbUrun.DisplayMember = "ProductName";
                    cmbUrun.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yükleme Hatası: " + ex.Message);
            }
        }

        private void btnSatisOnayla_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAdet.Text) || cmbMusteri.SelectedValue == null || cmbUrun.SelectedValue == null)
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!");
                return;
            }

            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();

                    // 1. ÜRÜN FİYATINI AL (Ciro için gerekli)
                    decimal urunFiyati = 0;
                    string fiyatSql = "SELECT SalePrice FROM Products WHERE Id = @urunId";
                    using (MySqlCommand cmdFiyat = new MySqlCommand(fiyatSql, baglan))
                    {
                        cmdFiyat.Parameters.AddWithValue("@urunId", cmbUrun.SelectedValue);
                        urunFiyati = Convert.ToDecimal(cmdFiyat.ExecuteScalar());
                    }

                    // 2. SATIŞ ANA KAYDI (Sales Tablosu)
                    string satisSql = "INSERT INTO Sales (CustomerId, SaleDate) VALUES (@cId, @tarih); SELECT LAST_INSERT_ID();";
                    int sonSatisId = 0;
                    using (MySqlCommand cmdSatis = new MySqlCommand(satisSql, baglan))
                    {
                        cmdSatis.Parameters.AddWithValue("@cId", cmbMusteri.SelectedValue);
                        cmdSatis.Parameters.AddWithValue("@tarih", DateTime.Now);
                        sonSatisId = Convert.ToInt32(cmdSatis.ExecuteScalar());
                    }

                    // 3. SATIŞ DETAY KAYDI (SalesDetails Tablosu - CİROYU OLUŞTURAN YER)
                    string detaySql = "INSERT INTO SalesDetails (SaleId, ProductId, Quantity, UnitPrice) VALUES (@sId, @pId, @qty, @price)";
                    using (MySqlCommand cmdDetay = new MySqlCommand(detaySql, baglan))
                    {
                        cmdDetay.Parameters.AddWithValue("@sId", sonSatisId);
                        cmdDetay.Parameters.AddWithValue("@pId", cmbUrun.SelectedValue);
                        cmdDetay.Parameters.AddWithValue("@qty", Convert.ToInt32(txtAdet.Text));
                        cmdDetay.Parameters.AddWithValue("@price", urunFiyati); // @price parametresi burada sadece 1 kez tanımlandı
                        cmdDetay.ExecuteNonQuery();
                    }

                    // 4. STOKTAN DÜŞ
                    string stokSql = "UPDATE Products SET StockQuantity = StockQuantity - @miktar WHERE Id = @uId";
                    using (MySqlCommand cmdStok = new MySqlCommand(stokSql, baglan))
                    {
                        cmdStok.Parameters.AddWithValue("@miktar", Convert.ToInt32(txtAdet.Text));
                        cmdStok.Parameters.AddWithValue("@uId", cmbUrun.SelectedValue);
                        cmdStok.ExecuteNonQuery();
                    }

                    MessageBox.Show("Satış başarıyla tamamlandı!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Satış Hatası: " + ex.Message);
            }
        }

        private void lblToplam_Click(object sender, EventArgs e)
        {

        }

        private void lblFiyat_Click(object sender, EventArgs e)
        {

        }

        private void txtAdet_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    } //namespace sonu
} //class sonu