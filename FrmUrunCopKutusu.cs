using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Stok_ve_Satış.DAL;

namespace Stok_ve_Satış
{
    public partial class FrmUrunCopKutusu : Form
    {
        public FrmUrunCopKutusu() { InitializeComponent(); }

        private void FrmUrunCopKutusu_Load(object sender, EventArgs e) { SilinenleriListele(); }

        private void SilinenleriListele()
        {
            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM DeletedProducts", baglan);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSilinenler.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            if (dgvSilinenler.CurrentRow == null) return;
            try
            {
                int id = Convert.ToInt32(dgvSilinenler.CurrentRow.Cells["Id"].Value);
                string ad = dgvSilinenler.CurrentRow.Cells["ProductName"].Value.ToString();
                decimal fiyat = Convert.ToDecimal(dgvSilinenler.CurrentRow.Cells["UnitPrice"].Value);
                int stok = Convert.ToInt32(dgvSilinenler.CurrentRow.Cells["StockQuantity"].Value);

                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();
                    string sqlGeri = "INSERT INTO Products (ProductName, Category, SalePrice, StockQuantity) VALUES (@ad, 'Genel', @fiyat, @stok)";
                    using (MySqlCommand cmdGeri = new MySqlCommand(sqlGeri, baglan))
                    {
                        cmdGeri.Parameters.AddWithValue("@ad", ad);
                        cmdGeri.Parameters.AddWithValue("@fiyat", fiyat);
                        cmdGeri.Parameters.AddWithValue("@stok", stok);
                        cmdGeri.ExecuteNonQuery();
                    }
                    using (MySqlCommand cmdSil = new MySqlCommand("DELETE FROM DeletedProducts WHERE Id=@id", baglan))
                    {
                        cmdSil.Parameters.AddWithValue("@id", id);
                        cmdSil.ExecuteNonQuery();
                    }
                    MessageBox.Show("Ürün Başarıyla Geri Yüklendi.");
                    SilinenleriListele();
                }
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }
    }
}