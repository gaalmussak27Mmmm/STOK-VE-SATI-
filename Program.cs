using System;
using System.Windows.Forms;

namespace Stok_ve_Satış
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Uygulama artık Form1 yerine FrmLogin (Giriş Ekranı) ile başlayacak
            Application.Run(new FrmLogin());
        }
    }
}