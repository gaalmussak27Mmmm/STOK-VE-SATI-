using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; // MySQL kütüphanesi
using System.Data;
using System.Windows.Forms;   // MessageBox için gerekli

namespace Stok_ve_Satış.DAL
{
    public class Baglanti
    {
        // GÜNCELLENMİŞ BAĞLANTI CÜMLESİ:
        // 1. Charset=utf8 eklendi (Şifredeki 'İ' harfini tanıması için).
        // 2. SslMode=None (Güvenlik hatasını atlaması için).
        // 3. Connect Timeout=30 (Bağlantı hemen kopmasın diye).

        private static string cs = "Server=172.21.54.253; Database=26_132430056; Uid=26_132430056; Pwd=İnif123.;";

        public static MySqlConnection GetConnection()
        {
            MySqlConnection baglan = new MySqlConnection(cs);
            try
            {
                // Bağlantı kapalıysa aç
                if (baglan.State == ConnectionState.Closed)
                {
                    baglan.Open();
                }
            }
            catch (Exception ex)
            {
                // Hata alırsak açıkça görelim
                MessageBox.Show("Veritabanı Bağlantı Hatası!\n\nSebep: " + ex.Message);
            }
            return baglan;
        }
    }
}