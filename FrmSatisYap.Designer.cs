namespace Stok_ve_Satış
{
    partial class FrmSatisYap
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnSatisYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(39, 45);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(180, 24);
            this.cmbMusteri.TabIndex = 0;
            this.cmbMusteri.SelectedIndexChanged += new System.EventHandler(this.cmbMusteri_SelectedIndexChanged);
            // 
            // cmbUrun
            // 
            this.cmbUrun.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(39, 117);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(180, 24);
            this.cmbUrun.TabIndex = 1;
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(285, 47);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(115, 22);
            this.txtAdet.TabIndex = 2;
            this.txtAdet.TextChanged += new System.EventHandler(this.txtAdet_TextChanged);
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiyat.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblFiyat.Location = new System.Drawing.Point(459, 263);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(146, 28);
            this.lblFiyat.TabIndex = 3;
            this.lblFiyat.Text = "Birim Fiyat: 0";
            this.lblFiyat.Click += new System.EventHandler(this.lblFiyat_Click);
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplam.ForeColor = System.Drawing.Color.Red;
            this.lblToplam.Location = new System.Drawing.Point(459, 228);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(136, 25);
            this.lblToplam.TabIndex = 4;
            this.lblToplam.Text = "Toplam Tutar: 0";
            this.lblToplam.Click += new System.EventHandler(this.lblToplam_Click);
            // 
            // btnSatisYap
            // 
            this.btnSatisYap.BackColor = System.Drawing.Color.LightGreen;
            this.btnSatisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSatisYap.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatisYap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSatisYap.Location = new System.Drawing.Point(39, 180);
            this.btnSatisYap.Name = "btnSatisYap";
            this.btnSatisYap.Size = new System.Drawing.Size(200, 40);
            this.btnSatisYap.TabIndex = 5;
            this.btnSatisYap.Text = "SATIŞI ONAYLA";
            this.btnSatisYap.UseVisualStyleBackColor = false;
            this.btnSatisYap.Click += new System.EventHandler(this.btnSatisOnayla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Müşteri Seçin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ürün Seçin:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stok_ve_Satış.Properties.Resources.dff;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(652, 302);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Adet:";
            // 
            // FrmSatisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 300);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSatisYap);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmSatisYap";
            this.Text = "Satış İşlemi";
            this.Load += new System.EventHandler(this.FrmSatisYap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnSatisYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}