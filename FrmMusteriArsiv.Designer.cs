namespace Stok_ve_Satış
{
    partial class FrmMusteriArsiv
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
            this.dgvArsiv = new System.Windows.Forms.DataGridView();
            this.btnGeriYukle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArsiv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArsiv
            // 
            this.dgvArsiv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArsiv.Location = new System.Drawing.Point(0, -3);
            this.dgvArsiv.Name = "dgvArsiv";
            this.dgvArsiv.RowHeadersWidth = 51;
            this.dgvArsiv.RowTemplate.Height = 24;
            this.dgvArsiv.Size = new System.Drawing.Size(891, 357);
            this.dgvArsiv.TabIndex = 0;
            this.dgvArsiv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArsiv_CellContentClick);
            this.dgvArsiv.Click += new System.EventHandler(this.FrmMusteriArsiv_Load);
            // 
            // btnGeriYukle
            // 
            this.btnGeriYukle.BackColor = System.Drawing.Color.DarkGreen;
            this.btnGeriYukle.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeriYukle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGeriYukle.Location = new System.Drawing.Point(175, 382);
            this.btnGeriYukle.Name = "btnGeriYukle";
            this.btnGeriYukle.Size = new System.Drawing.Size(493, 37);
            this.btnGeriYukle.TabIndex = 1;
            this.btnGeriYukle.Text = "Geri Yükle";
            this.btnGeriYukle.UseVisualStyleBackColor = false;
            this.btnGeriYukle.Click += new System.EventHandler(this.btnGeriYukle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stok_ve_Satış.Properties.Resources.çöp;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(799, 357);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMusteriArsiv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnGeriYukle);
            this.Controls.Add(this.dgvArsiv);
            this.Name = "FrmMusteriArsiv";
            this.Text = "FrmMusteriArsiv";
            this.Load += new System.EventHandler(this.FrmMusteriArsiv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArsiv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArsiv;
        private System.Windows.Forms.Button btnGeriYukle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}