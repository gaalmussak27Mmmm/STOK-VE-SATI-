using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Stok_ve_Satış.DAL;

namespace Stok_ve_Satış
{
    public partial class FrmMusteriCopKutusu : Form
    {
        public FrmMusteriCopKutusu()
        {
            InitializeComponent();
        }

        private void FrmMusteriCopKutusu_Load(object sender, EventArgs e)
        {
            MusteriCopKutusunuDoldur();
        }

        private void MusteriCopKutusunuDoldur()
        {
            try
            {
                using (MySqlConnection baglan = Baglanti.GetConnection())
                {
                    if (baglan.State == ConnectionState.Closed) baglan.Open();

                    // Tablo adının DeletedCustomers olduğundan emin olun (phpMyAdmin'deki ile aynı olmalı)
                    string sorgu = "SELECT * FROM DeletedCustomers ORDER BY DeletionDate DESC";

                    MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglan);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // HATA BURADAYDI: dgvMusteriCop isminin tasarımda tanımlı olması şarttır.
                    dgvMusteriCop.DataSource = dt;

                    // Sütunların mevcut olup olmadığını kontrol ederek başlıkları düzenleyelim
                    if (dgvMusteriCop.Columns.Count > 0)
                    {
                        if (dgvMusteriCop.Columns.Contains("FullName")) dgvMusteriCop.Columns["FullName"].HeaderText = "Müşteri Adı";
                        if (dgvMusteriCop.Columns.Contains("Phone")) dgvMusteriCop.Columns["Phone"].HeaderText = "Telefon";
                        if (dgvMusteriCop.Columns.Contains("DeletionDate")) dgvMusteriCop.Columns["DeletionDate"].HeaderText = "Silinme Tarihi";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}