namespace Stok_ve_Satış
{
    partial class FrmUrunler
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
            this.dgvUrunler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSatisFiyat = new System.Windows.Forms.TextBox();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.txtUrunAd = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnUrunCopKutusu = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUrunler
            // 
            this.dgvUrunler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUrunler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvUrunler.Location = new System.Drawing.Point(0, 212);
            this.dgvUrunler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUrunler.Name = "dgvUrunler";
            this.dgvUrunler.RowHeadersWidth = 51;
            this.dgvUrunler.RowTemplate.Height = 24;
            this.dgvUrunler.Size = new System.Drawing.Size(800, 322);
            this.dgvUrunler.TabIndex = 0;
            this.dgvUrunler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUrunler_CellContentClick);
            this.dgvUrunler.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvUrunler_DataError);
            this.dgvUrunler.Click += new System.EventHandler(this.FrmUrunler_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(337, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Stok Adedi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(486, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fiyat:";
            // 
            // txtSatisFiyat
            // 
            this.txtSatisFiyat.Location = new System.Drawing.Point(458, 90);
            this.txtSatisFiyat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSatisFiyat.Name = "txtSatisFiyat";
            this.txtSatisFiyat.Size = new System.Drawing.Size(100, 26);
            this.txtSatisFiyat.TabIndex = 4;
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(331, 90);
            this.txtStok.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 26);
            this.txtStok.TabIndex = 5;
            // 
            // txtUrunAd
            // 
            this.txtUrunAd.Location = new System.Drawing.Point(201, 90);
            this.txtUrunAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrunAd.Name = "txtUrunAd";
            this.txtUrunAd.Size = new System.Drawing.Size(100, 26);
            this.txtUrunAd.TabIndex = 6;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.Color.Yellow;
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Location = new System.Drawing.Point(282, 147);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(196, 27);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Ürünü Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.Red;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(16, 26);
            this.btnSil.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 27);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Seçili Ürünü Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(16, 61);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(130, 26);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "Bilgileri Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnUrunGuncelle_Click);
            // 
            // btnUrunCopKutusu
            // 
            this.btnUrunCopKutusu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUrunCopKutusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUrunCopKutusu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUrunCopKutusu.Location = new System.Drawing.Point(16, 95);
            this.btnUrunCopKutusu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUrunCopKutusu.Name = "btnUrunCopKutusu";
            this.btnUrunCopKutusu.Size = new System.Drawing.Size(130, 58);
            this.btnUrunCopKutusu.TabIndex = 10;
            this.btnUrunCopKutusu.Text = "Silinen Ürünler";
            this.btnUrunCopKutusu.UseVisualStyleBackColor = false;
            this.btnUrunCopKutusu.Click += new System.EventHandler(this.btnUrunCopKutusu_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnUrunCopKutusu);
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(627, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(161, 169);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Bilgileri";
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtUrunAd);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.txtSatisFiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUrunler);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUrunler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunler)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSatisFiyat;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtUrunAd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnUrunCopKutusu;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}