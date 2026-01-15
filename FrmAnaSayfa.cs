using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Stok_ve_Satış.DAL;

namespace Stok_ve_Satış
{
    public partial class FrmAnaSayfa : Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            IstatistikleriGuncelle();
        }

        public void IstatistikleriGuncelle()
        {
            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == System.Data.ConnectionState.Closed) baglan.Open();

                    // Ürün Sayısı
                    MySqlCommand cmdUrun = new MySqlCommand("SELECT COUNT(*) FROM Products", baglan);
                    // Eğer veritabanı boşsa hata vermemesi için kontrol
                    object sonucUrun = cmdUrun.ExecuteScalar();
                    lblToplamUrun.Text = "Toplam Ürün: " + (sonucUrun != null ? sonucUrun.ToString() : "0");

                    // Müşteri Sayısı
                    MySqlCommand cmdMusteri = new MySqlCommand("SELECT COUNT(*) FROM Customers", baglan);
                    object sonucMusteri = cmdMusteri.ExecuteScalar();
                    lblToplamMusteri.Text = "Müşteri Sayısı: " + (sonucMusteri != null ? sonucMusteri.ToString() : "0");

                    // Satış Sayısı
                    MySqlCommand cmdSatis = new MySqlCommand("SELECT COUNT(*) FROM Sales", baglan);
                    object sonucSatis = cmdSatis.ExecuteScalar();
                    lblToplamSatis.Text = "Yapılan Satış: " + (sonucSatis != null ? sonucSatis.ToString() : "0");
                }
            }
            catch (Exception)
            {
                // Hata durumunda programın durmaması için boş geçiyoruz
            }
        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            FrmUrunler frm = new FrmUrunler();
            frm.Show();
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            FrmMusteriler frm = new FrmMusteriler();
            frm.Show();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            FrmSatisYap frm = new FrmSatisYap();
            // Satış yapıldığında ana sayfa rakamlarını yenile
            frm.FormClosed += (s, args) => IstatistikleriGuncelle();
            frm.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            FrmRaporlar rapor = new FrmRaporlar();
            rapor.Show();
        }

        private void btnRaporlar_Click_1(object sender, EventArgs e)
        {
            FrmRaporlar frm = new FrmRaporlar();
            frm.ShowDialog(); // Rapor formunu açar
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}