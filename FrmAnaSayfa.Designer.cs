namespace Stok_ve_Satış
{
    partial class FrmAnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.btnRaporlar = new System.Windows.Forms.Button();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.btnMusteriYonetimi = new System.Windows.Forms.Button();
            this.btnUrunYonetimi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMusteri = new System.Windows.Forms.Panel();
            this.lblToplamMusteri = new System.Windows.Forms.Label();
            this.pnlUrun = new System.Windows.Forms.Panel();
            this.lblToplamUrun = new System.Windows.Forms.Label();
            this.pnlSatis = new System.Windows.Forms.Panel();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlMusteri.SuspendLayout();
            this.pnlUrun.SuspendLayout();
            this.pnlSatis.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lblKullanici);
            this.panel1.Controls.Add(this.btnRaporlar);
            this.panel1.Controls.Add(this.btnSatisYap);
            this.panel1.Controls.Add(this.btnMusteriYonetimi);
            this.panel1.Controls.Add(this.btnUrunYonetimi);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 152);
            this.panel1.TabIndex = 0;
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(915, 18);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(44, 16);
            this.lblKullanici.TabIndex = 5;
            this.lblKullanici.Text = "label2";
            // 
            // btnRaporlar
            // 
            this.btnRaporlar.Location = new System.Drawing.Point(472, 97);
            this.btnRaporlar.Name = "btnRaporlar";
            this.btnRaporlar.Size = new System.Drawing.Size(138, 23);
            this.btnRaporlar.TabIndex = 4;
            this.btnRaporlar.Text = "Raporlar";
            this.btnRaporlar.UseVisualStyleBackColor = true;
            this.btnRaporlar.Click += new System.EventHandler(this.btnRaporlar_Click_1);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.BackColor = System.Drawing.Color.Snow;
            this.btnSatisYap.Location = new System.Drawing.Point(650, 97);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(138, 23);
            this.btnSatisYap.TabIndex = 3;
            this.btnSatisYap.Text = "Satış Yap";
            this.btnSatisYap.UseVisualStyleBackColor = false;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisYap_Click);
            // 
            // btnMusteriYonetimi
            // 
            this.btnMusteriYonetimi.Location = new System.Drawing.Point(301, 97);
            this.btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            this.btnMusteriYonetimi.Size = new System.Drawing.Size(138, 23);
            this.btnMusteriYonetimi.TabIndex = 2;
            this.btnMusteriYonetimi.Text = "Müşteri Yönetimi";
            this.btnMusteriYonetimi.UseVisualStyleBackColor = true;
            this.btnMusteriYonetimi.Click += new System.EventHandler(this.btnMusteriYonetimi_Click);
            // 
            // btnUrunYonetimi
            // 
            this.btnUrunYonetimi.Location = new System.Drawing.Point(134, 97);
            this.btnUrunYonetimi.Name = "btnUrunYonetimi";
            this.btnUrunYonetimi.Size = new System.Drawing.Size(138, 23);
            this.btnUrunYonetimi.TabIndex = 1;
            this.btnUrunYonetimi.Text = "Ürün Yönetimi";
            this.btnUrunYonetimi.UseVisualStyleBackColor = true;
            this.btnUrunYonetimi.Click += new System.EventHandler(this.btnUrunYonetimi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok ve Satış Takip Sistemi";
            // 
            // pnlMusteri
            // 
            this.pnlMusteri.BackColor = System.Drawing.Color.Lime;
            this.pnlMusteri.Controls.Add(this.lblToplamMusteri);
            this.pnlMusteri.Location = new System.Drawing.Point(353, 206);
            this.pnlMusteri.Name = "pnlMusteri";
            this.pnlMusteri.Size = new System.Drawing.Size(200, 100);
            this.pnlMusteri.TabIndex = 1;
            // 
            // lblToplamMusteri
            // 
            this.lblToplamMusteri.AutoSize = true;
            this.lblToplamMusteri.Location = new System.Drawing.Point(48, 44);
            this.lblToplamMusteri.Name = "lblToplamMusteri";
            this.lblToplamMusteri.Size = new System.Drawing.Size(110, 16);
            this.lblToplamMusteri.TabIndex = 0;
            this.lblToplamMusteri.Text = "Müşteri Sayısı: 12";
            // 
            // pnlUrun
            // 
            this.pnlUrun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUrun.Controls.Add(this.lblToplamUrun);
            this.pnlUrun.Location = new System.Drawing.Point(61, 206);
            this.pnlUrun.Name = "pnlUrun";
            this.pnlUrun.Size = new System.Drawing.Size(200, 100);
            this.pnlUrun.TabIndex = 2;
            // 
            // lblToplamUrun
            // 
            this.lblToplamUrun.AutoSize = true;
            this.lblToplamUrun.Location = new System.Drawing.Point(42, 44);
            this.lblToplamUrun.Name = "lblToplamUrun";
            this.lblToplamUrun.Size = new System.Drawing.Size(95, 16);
            this.lblToplamUrun.TabIndex = 0;
            this.lblToplamUrun.Text = "Ürün Sayısı: 45";
            // 
            // pnlSatis
            // 
            this.pnlSatis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlSatis.Controls.Add(this.lblToplamSatis);
            this.pnlSatis.Location = new System.Drawing.Point(660, 206);
            this.pnlSatis.Name = "pnlSatis";
            this.pnlSatis.Size = new System.Drawing.Size(200, 100);
            this.pnlSatis.TabIndex = 3;
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.Location = new System.Drawing.Point(37, 44);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(140, 16);
            this.lblToplamSatis.TabIndex = 0;
            this.lblToplamSatis.Text = "Toplam Satış: 1500 TL";
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 372);
            this.Controls.Add(this.pnlSatis);
            this.Controls.Add(this.pnlUrun);
            this.Controls.Add(this.pnlMusteri);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAnaSayfa";
            this.Text = "FrmAnaSayfa";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlMusteri.ResumeLayout(false);
            this.pnlMusteri.PerformLayout();
            this.pnlUrun.ResumeLayout(false);
            this.pnlUrun.PerformLayout();
            this.pnlSatis.ResumeLayout(false);
            this.pnlSatis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRaporlar;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Button btnMusteriYonetimi;
        private System.Windows.Forms.Button btnUrunYonetimi;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Panel pnlMusteri;
        private System.Windows.Forms.Label lblToplamMusteri;
        private System.Windows.Forms.Panel pnlUrun;
        private System.Windows.Forms.Label lblToplamUrun;
        private System.Windows.Forms.Panel pnlSatis;
        private System.Windows.Forms.Label lblToplamSatis;
    }
}