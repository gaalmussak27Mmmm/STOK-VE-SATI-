using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Stok_ve_Satış.DAL;

namespace Stok_ve_Satış
{
    public partial class FrmSatisCopKutusu : Form
    {
        public FrmSatisCopKutusu()
        {
            InitializeComponent();
        }

        private void FrmSatisCopKutusu_Load(object sender, EventArgs e)
        {
            SilinenSatislariListele();
        }

        private void SilinenSatislariListele()
        {
            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();
                    // Silinen satışları müşteri adıyla birlikte getirelim
                    string sorgu = @"SELECT s.Id, c.FullName AS Musteri, s.TotalAmount, s.SaleDate, s.DeletionDate 
                                   FROM DeletedSales s
                                   LEFT JOIN Customers c ON s.CustomerId = c.Id
                                   ORDER BY s.DeletionDate DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSatisCop.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme Hatası: " + ex.Message);
            }
        }
    }
}