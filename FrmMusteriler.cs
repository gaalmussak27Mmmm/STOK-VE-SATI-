using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Stok_ve_Satış.DAL;

namespace Stok_ve_Satış
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler() { InitializeComponent(); }

        private void FrmMusteriler_Load(object sender, EventArgs e) { MusterileriListele(); }

        private void MusterileriListele()
        {
            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();
                    // Tablonun tamamını çekiyoruz
                    MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM Customers", baglan);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvMusteriler.DataSource = dt;
                }
            }
            catch (Exception ex) { MessageBox.Show("Liste Hatası: " + ex.Message); }
        }

        // 1. CLICK: KAYDET (Address hatası düzeltildi)
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();
                    string sql = "INSERT INTO Customers (FullName, Phone, Address) VALUES (@p1, @p2, @p3)";
                    using (MySqlCommand cmd = new MySqlCommand(sql, baglan))
                    {
                        cmd.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
                        cmd.Parameters.AddWithValue("@p2", txtTelefon.Text);
                        cmd.Parameters.AddWithValue("@p3", txtAdres.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Müşteri Kaydedildi.");
                    MusterileriListele();
                }
            }
            catch (Exception ex) { MessageBox.Show("Kayıt Hatası: " + ex.Message); }
        }

        // 2. CLICK: GÜNCELLE
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow == null) return;
            try
            {
                int id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells["Id"].Value);
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();
                    string sql = "UPDATE Customers SET FullName=@p1, Phone=@p2, Address=@p3 WHERE Id=@id";
                    using (MySqlCommand cmd = new MySqlCommand(sql, baglan))
                    {
                        cmd.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
                        cmd.Parameters.AddWithValue("@p2", txtTelefon.Text);
                        cmd.Parameters.AddWithValue("@p3", txtAdres.Text);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Güncelleme Başarılı.");
                    MusterileriListele();
                }
            }
            catch (Exception ex) { MessageBox.Show("Güncelleme Hatası: " + ex.Message); }
        }

        // 3. CLICK: SİL (ArchivedCustomers tablosuna taşıma)
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMusteriler.CurrentRow == null) return;
            int id = Convert.ToInt32(dgvMusteriler.CurrentRow.Cells["Id"].Value);

            using (MySqlConnection baglan = Baglanti.GetConnection())
            {
                if (baglan.State == ConnectionState.Closed) baglan.Open();
                using (MySqlTransaction tr = baglan.BeginTransaction())
                {
                    try
                    {
                        // Önce arşive kopyala
                        string sqlArsiv = "INSERT INTO ArchivedCustomers (Id, FullName, Phone, Address) " +
                                         "SELECT Id, FullName, Phone, Address FROM Customers WHERE Id = @id";
                        using (MySqlCommand cmd = new MySqlCommand(sqlArsiv, baglan, tr))
                        {
                            cmd.Parameters.AddWithValue("@id", id);
                            cmd.ExecuteNonQuery();
                        }
                        // Sonra ana tablodan sil
                        using (MySqlCommand cmdSil = new MySqlCommand("DELETE FROM Customers WHERE Id = @id", baglan, tr))
                        {
                            cmdSil.Parameters.AddWithValue("@id", id);
                            cmdSil.ExecuteNonQuery();
                        }
                        tr.Commit();
                        MessageBox.Show("Müşteri arşivlendi.");
                        MusterileriListele();
                    }
                    catch (Exception ex)
                    {
                        if (tr.Connection != null) tr.Rollback(); // Güvenli Rollback
                        MessageBox.Show("Arşivleme Hatası: " + ex.Message);
                    }
                }
            }
        }

        // 4. CLICK: SİLİNEN MÜŞTERİLER (ÇÖP KUTUSU)
        private void btnMusteriCopKutusu_Click(object sender, EventArgs e)
        {
            FrmMusteriArsiv arsivForm = new FrmMusteriArsiv();
            arsivForm.ShowDialog();
            MusterileriListele(); // Geri dönünce listeyi tazele
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}