namespace Stok_ve_Satış
{
    partial class FrmUrunCopKutusu
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
            this.dgvSilinenler = new System.Windows.Forms.DataGridView();
            this.btnGeriYukle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilinenler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSilinenler
            // 
            this.dgvSilinenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSilinenler.Location = new System.Drawing.Point(1, -1);
            this.dgvSilinenler.Name = "dgvSilinenler";
            this.dgvSilinenler.RowHeadersWidth = 51;
            this.dgvSilinenler.RowTemplate.Height = 24;
            this.dgvSilinenler.Size = new System.Drawing.Size(807, 381);
            this.dgvSilinenler.TabIndex = 0;
            
            this.dgvSilinenler.Click += new System.EventHandler(this.FrmUrunCopKutusu_Load);
            // 
            // btnGeriYukle
            // 
            this.btnGeriYukle.Location = new System.Drawing.Point(182, 407);
            this.btnGeriYukle.Name = "btnGeriYukle";
            this.btnGeriYukle.Size = new System.Drawing.Size(486, 33);
            this.btnGeriYukle.TabIndex = 1;
            this.btnGeriYukle.Text = "Seçili Ürünü Geri Yükle";
            this.btnGeriYukle.UseVisualStyleBackColor = true;
            this.btnGeriYukle.Click += new System.EventHandler(this.btnGeriYukle_Click);
            // 
            // FrmUrunCopKutusu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 452);
            this.Controls.Add(this.btnGeriYukle);
            this.Controls.Add(this.dgvSilinenler);
            this.Name = "FrmUrunCopKutusu";
            this.Text = "FrmUrunCopKutusu";
            this.Load += new System.EventHandler(this.FrmUrunCopKutusu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSilinenler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSilinenler;
        private System.Windows.Forms.Button btnGeriYukle;
    }
}