using System;
using System.Windows.Forms;

namespace Stok_ve_Satış
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAd.Text == "admin" && txtSifre.Text == "1234")
            {
                FrmAnaSayfa ana = new FrmAnaSayfa();
                ana.Show(); // ShowDialog yerine sadece Show kullanıyoruz
                this.Hide(); // Login formunu tamamen gizliyoruz
            }
            else { MessageBox.Show("Hatalı Giriş!"); }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtKullaniciAd_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
