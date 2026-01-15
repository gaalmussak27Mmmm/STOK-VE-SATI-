using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Stok_ve_Satış.DAL; // Bağlantı sınıfının bulunduğu klasör

namespace Stok_ve_Satış
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            // 1. ADIM: Boş alan kontrolü (Kullanıcı hata yapmasın)
            if (string.IsNullOrEmpty(txtKullaniciAdi.Text) || string.IsNullOrEmpty(txtSifre.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // 2. ADIM: Veritabanı bağlantısını alıyoruz
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    // Bağlantı kapalıysa aç
                    if (baglan.State == ConnectionState.Closed)
                    {
                        baglan.Open();
                    }

                    // 3. ADIM: Sorguyu hazırlıyoruz (Tablo adını 'users' yaptık)
                    string sorgu = "SELECT * FROM Users WHERE username=@p1 AND password=@p2";
                    MySqlCommand komut = new MySqlCommand(sorgu, baglan);

                    // Parametreleri güvenli bir şekilde ekliyoruz
                    komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@p2", txtSifre.Text.Trim());

                    // 4. ADIM: Sorguyu çalıştır ve oku
                    using (MySqlDataReader dr = komut.ExecuteReader())
                    {
                        if (dr.Read()) // Eğer veritabanında böyle bir kullanıcı varsa
                        {
                            MessageBox.Show("Giriş Başarılı! Sisteme yönlendiriliyorsunuz.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Ana sayfayı aç
                            FrmAnaSayfa ana = new FrmAnaSayfa();
                            ana.Show();

                            // Giriş formunu gizle
                            this.Hide();
                        }
                        else // Eğer kullanıcı adı veya şifre eşleşmediyse
                        {
                            MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Giriş Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Bir hata olursa (bağlantı kopması vs.) detayını gösterir
                MessageBox.Show("Sistemsel Bir Hata Oluştu:\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}