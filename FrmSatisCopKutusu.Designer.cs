namespace Stok_ve_Satış
{
    partial class FrmSatisCopKutusu
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
            this.dgvSatisCop = new System.Windows.Forms.DataGridView();
            this.btnGeriYukle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisCop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSatisCop
            // 
            this.dgvSatisCop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSatisCop.Location = new System.Drawing.Point(-2, -4);
            this.dgvSatisCop.Name = "dgvSatisCop";
            this.dgvSatisCop.RowHeadersWidth = 51;
            this.dgvSatisCop.RowTemplate.Height = 24;
            this.dgvSatisCop.Size = new System.Drawing.Size(806, 390);
            this.dgvSatisCop.TabIndex = 0;
            this.dgvSatisCop.Click += new System.EventHandler(this.FrmSatisCopKutusu_Load);
            // 
            // btnGeriYukle
            // 
            this.btnGeriYukle.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGeriYukle.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriYukle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeriYukle.Location = new System.Drawing.Point(158, 401);
            this.btnGeriYukle.Name = "btnGeriYukle";
            this.btnGeriYukle.Size = new System.Drawing.Size(473, 37);
            this.btnGeriYukle.TabIndex = 1;
            this.btnGeriYukle.Text = "Geri Yükle";
            this.btnGeriYukle.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stok_ve_Satış.Properties.Resources.çöp;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(817, 390);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmSatisCopKutusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGeriYukle);
            this.Controls.Add(this.dgvSatisCop);
            this.Name = "FrmSatisCopKutusu";
            this.Text = "FrmSatisCopKutusu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatisCop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSatisCop;
        private System.Windows.Forms.Button btnGeriYukle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}