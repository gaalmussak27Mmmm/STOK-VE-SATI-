using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Stok_ve_Satış.DAL;

namespace Stok_ve_Satış
{
    public partial class FrmCopKutusu : Form
    {
        public FrmCopKutusu()
        {
            InitializeComponent();
        }

        private void FrmCopKutusu_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    string sql = "SELECT * FROM DeletedSales ORDER BY DeletionDate DESC";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, baglan);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvCop.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Yükleme Hatası: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}