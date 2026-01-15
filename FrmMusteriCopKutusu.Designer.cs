namespace Stok_ve_Satış
{
    partial class FrmMusteriCopKutusu
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
            this.dgvMusteriCop = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriCop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMusteriCop
            // 
            this.dgvMusteriCop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMusteriCop.Location = new System.Drawing.Point(2, 1);
            this.dgvMusteriCop.Name = "dgvMusteriCop";
            this.dgvMusteriCop.RowHeadersWidth = 51;
            this.dgvMusteriCop.RowTemplate.Height = 24;
            this.dgvMusteriCop.Size = new System.Drawing.Size(805, 457);
            this.dgvMusteriCop.TabIndex = 0;
            this.dgvMusteriCop.Click += new System.EventHandler(this.FrmMusteriCopKutusu_Load);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Stok_ve_Satış.Properties.Resources.çöp;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 457);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMusteriCopKutusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvMusteriCop);
            this.Name = "FrmMusteriCopKutusu";
            this.Text = "FrmMusteriCopKutusu";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMusteriCop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMusteriCop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}