using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Stok_ve_Satış.DAL;

namespace Stok_ve_Satış
{
    public partial class FrmMusteriArsiv : Form
    {
        public FrmMusteriArsiv() { InitializeComponent(); }

        private void FrmMusteriArsiv_Load(object sender, EventArgs e) { ArshiviListele(); }

        private void ArshiviListele()
        {
            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM ArchivedCustomers", baglan);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvArsiv.DataSource = dt; // Grid adı doğru olmalı
                }
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        // GERİ YÜKLE CLICK
        private void btnGeriYukle_Click(object sender, EventArgs e)
        {
            if (dgvArsiv.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvArsiv.CurrentRow.Cells["Id"].Value);
            using (MySqlConnection baglan = Baglanti.GetConnection())
            {
                if (baglan.State == ConnectionState.Closed) baglan.Open();
                try
                {
                    string sql = "INSERT INTO Customers (FullName, Phone, Address) SELECT FullName, Phone, Address FROM ArchivedCustomers WHERE Id=@id";
                    new MySqlCommand(sql, baglan).Parameters.AddWithValue("@id", id);
                    new MySqlCommand("DELETE FROM ArchivedCustomers WHERE Id=" + id, baglan).ExecuteNonQuery();
                    MessageBox.Show("Müşteri geri yüklendi.");
                    ArshiviListele();
                }
                catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
            }
        }

        private void dgvArsiv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}