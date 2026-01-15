namespace Stok_ve_Satış
{
    partial class FrmRaporlar
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
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.lblToplamSatis = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.lblToplamCiro = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.btnExcelAktar = new System.Windows.Forms.Button();
            this.btnSatisSil = new System.Windows.Forms.Button();
            this.btnCopKutusu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRapor
            // 
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRapor.Location = new System.Drawing.Point(0, 0);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.RowHeadersWidth = 51;
            this.dgvRapor.RowTemplate.Height = 24;
            this.dgvRapor.Size = new System.Drawing.Size(800, 450);
            this.dgvRapor.TabIndex = 0;
            this.dgvRapor.Click += new System.EventHandler(this.btnCopKutusu_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.BackColor = System.Drawing.Color.Yellow;
            this.btnYenile.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYenile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnYenile.Location = new System.Drawing.Point(59, 21);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(222, 54);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "Güncel Tablo";
            this.btnYenile.UseVisualStyleBackColor = false;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // lblToplamSatis
            // 
            this.lblToplamSatis.AutoSize = true;
            this.lblToplamSatis.BackColor = System.Drawing.Color.Gold;
            this.lblToplamSatis.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamSatis.Location = new System.Drawing.Point(74, 89);
            this.lblToplamSatis.Name = "lblToplamSatis";
            this.lblToplamSatis.Size = new System.Drawing.Size(218, 25);
            this.lblToplamSatis.TabIndex = 2;
            this.lblToplamSatis.Text = "Satış Geçmişi ve Raporlar";
            this.lblToplamSatis.Click += new System.EventHandler(this.FrmRaporlar_Load);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // lblToplamCiro
            // 
            this.lblToplamCiro.AutoSize = true;
            this.lblToplamCiro.BackColor = System.Drawing.Color.DarkGreen;
            this.lblToplamCiro.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToplamCiro.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblToplamCiro.Location = new System.Drawing.Point(110, 136);
            this.lblToplamCiro.Name = "lblToplamCiro";
            this.lblToplamCiro.Size = new System.Drawing.Size(126, 28);
            this.lblToplamCiro.TabIndex = 3;
            this.lblToplamCiro.Text = "Toplam Ciro";
            this.lblToplamCiro.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.CalendarMonthBackground = System.Drawing.SystemColors.HighlightText;
            this.dtpBaslangic.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBaslangic.Location = new System.Drawing.Point(588, 12);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(200, 23);
            this.dtpBaslangic.TabIndex = 4;
            // 
            // dtpBitis
            // 
            this.dtpBitis.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBitis.Location = new System.Drawing.Point(589, 40);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(200, 23);
            this.dtpBitis.TabIndex = 5;
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.BackColor = System.Drawing.Color.Gold;
            this.btnFiltrele.Font = new System.Drawing.Font("Impact", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrele.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFiltrele.Location = new System.Drawing.Point(588, 68);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(200, 28);
            this.btnFiltrele.TabIndex = 6;
            this.btnFiltrele.Text = "Tarihe Göre Getir";
            this.btnFiltrele.UseVisualStyleBackColor = false;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // btnExcelAktar
            // 
            this.btnExcelAktar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExcelAktar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcelAktar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcelAktar.Location = new System.Drawing.Point(647, 360);
            this.btnExcelAktar.Name = "btnExcelAktar";
            this.btnExcelAktar.Size = new System.Drawing.Size(141, 82);
            this.btnExcelAktar.TabIndex = 7;
            this.btnExcelAktar.Text = "Excel\'e Aktar";
            this.btnExcelAktar.UseVisualStyleBackColor = false;
            this.btnExcelAktar.Click += new System.EventHandler(this.btnExcelAktar_Click);
            // 
            // btnSatisSil
            // 
            this.btnSatisSil.BackColor = System.Drawing.Color.Red;
            this.btnSatisSil.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSatisSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSatisSil.Location = new System.Drawing.Point(12, 362);
            this.btnSatisSil.Name = "btnSatisSil";
            this.btnSatisSil.Size = new System.Drawing.Size(335, 78);
            this.btnSatisSil.TabIndex = 8;
            this.btnSatisSil.Text = "Seçili Satışı Sil";
            this.btnSatisSil.UseVisualStyleBackColor = false;
            this.btnSatisSil.Click += new System.EventHandler(this.btnSatisSil_Click);
            // 
            // btnCopKutusu
            // 
            this.btnCopKutusu.BackColor = System.Drawing.Color.Gold;
            this.btnCopKutusu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopKutusu.ForeColor = System.Drawing.Color.Black;
            this.btnCopKutusu.Location = new System.Drawing.Point(353, 360);
            this.btnCopKutusu.Name = "btnCopKutusu";
            this.btnCopKutusu.Size = new System.Drawing.Size(141, 84);
            this.btnCopKutusu.TabIndex = 9;
            this.btnCopKutusu.Text = "Çöp Kutusu";
            this.btnCopKutusu.UseVisualStyleBackColor = false;
            this.btnCopKutusu.Click += new System.EventHandler(this.btnCopKutusu_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(500, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 82);
            this.button1.TabIndex = 10;
            this.button1.Text = "Silinen Satışlar (Arşiv)";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblToplamSatis);
            this.groupBox1.Controls.Add(this.btnYenile);
            this.groupBox1.Controls.Add(this.lblToplamCiro);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 167);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Stok_ve_Satış.Properties.Resources.depo2;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 167);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stok_ve_Satış.Properties.Resources.ozel_raporlar1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 463);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // FrmRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCopKutusu);
            this.Controls.Add(this.btnSatisSil);
            this.Controls.Add(this.btnExcelAktar);
            this.Controls.Add(this.btnFiltrele);
            this.Controls.Add(this.dtpBitis);
            this.Controls.Add(this.dtpBaslangic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvRapor);
            this.Name = "FrmRaporlar";
            this.Text = "FrmRaporlar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Label lblToplamSatis;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Label lblToplamCiro;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Button btnExcelAktar;
        private System.Windows.Forms.Button btnSatisSil;
        private System.Windows.Forms.Button btnCopKutusu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}