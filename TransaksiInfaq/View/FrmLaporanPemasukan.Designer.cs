namespace TransaksiInfaq.View
{
    partial class FrmLaporanPemasukan
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
            this.btnHapusPemasukan = new System.Windows.Forms.Button();
            this.btnPerbaikiPemasukan = new System.Windows.Forms.Button();
            this.btnTambahPemasukan = new System.Windows.Forms.Button();
            this.lsvLaporanPemasukan = new System.Windows.Forms.ListView();
            this.txtCariPemasukan = new System.Windows.Forms.TextBox();
            this.btnExportLaporanPemasukan = new System.Windows.Forms.Button();
            this.btnRefreshDataPemasukan = new System.Windows.Forms.Button();
            this.btnCariLaporanPengeluaran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHapusPemasukan
            // 
            this.btnHapusPemasukan.Location = new System.Drawing.Point(1088, 519);
            this.btnHapusPemasukan.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapusPemasukan.Name = "btnHapusPemasukan";
            this.btnHapusPemasukan.Size = new System.Drawing.Size(189, 28);
            this.btnHapusPemasukan.TabIndex = 1;
            this.btnHapusPemasukan.Text = "Hapus";
            this.btnHapusPemasukan.UseVisualStyleBackColor = true;
            this.btnHapusPemasukan.Click += new System.EventHandler(this.btnHapusPemasukan_Click);
            // 
            // btnPerbaikiPemasukan
            // 
            this.btnPerbaikiPemasukan.Location = new System.Drawing.Point(896, 519);
            this.btnPerbaikiPemasukan.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerbaikiPemasukan.Name = "btnPerbaikiPemasukan";
            this.btnPerbaikiPemasukan.Size = new System.Drawing.Size(184, 28);
            this.btnPerbaikiPemasukan.TabIndex = 2;
            this.btnPerbaikiPemasukan.Text = "Perbaiki";
            this.btnPerbaikiPemasukan.UseVisualStyleBackColor = true;
            this.btnPerbaikiPemasukan.Click += new System.EventHandler(this.btnPerbaikiPemasukan_Click);
            // 
            // btnTambahPemasukan
            // 
            this.btnTambahPemasukan.Location = new System.Drawing.Point(697, 519);
            this.btnTambahPemasukan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahPemasukan.Name = "btnTambahPemasukan";
            this.btnTambahPemasukan.Size = new System.Drawing.Size(191, 28);
            this.btnTambahPemasukan.TabIndex = 3;
            this.btnTambahPemasukan.Text = "Tambah";
            this.btnTambahPemasukan.UseVisualStyleBackColor = true;
            this.btnTambahPemasukan.Click += new System.EventHandler(this.btnTambahPemasukan_Click);
            // 
            // lsvLaporanPemasukan
            // 
            this.lsvLaporanPemasukan.HideSelection = false;
            this.lsvLaporanPemasukan.Location = new System.Drawing.Point(-4, 63);
            this.lsvLaporanPemasukan.Margin = new System.Windows.Forms.Padding(4);
            this.lsvLaporanPemasukan.Name = "lsvLaporanPemasukan";
            this.lsvLaporanPemasukan.Size = new System.Drawing.Size(1285, 448);
            this.lsvLaporanPemasukan.TabIndex = 4;
            this.lsvLaporanPemasukan.UseCompatibleStateImageBehavior = false;
            // 
            // txtCariPemasukan
            // 
            this.txtCariPemasukan.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariPemasukan.Location = new System.Drawing.Point(13, 31);
            this.txtCariPemasukan.Name = "txtCariPemasukan";
            this.txtCariPemasukan.Size = new System.Drawing.Size(941, 23);
            this.txtCariPemasukan.TabIndex = 5;
            this.txtCariPemasukan.Text = "Ketik kode masuk";
            this.txtCariPemasukan.TextChanged += new System.EventHandler(this.txtCariPemasukan_TextChanged);
            // 
            // btnExportLaporanPemasukan
            // 
            this.btnExportLaporanPemasukan.Location = new System.Drawing.Point(1177, 29);
            this.btnExportLaporanPemasukan.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportLaporanPemasukan.Name = "btnExportLaporanPemasukan";
            this.btnExportLaporanPemasukan.Size = new System.Drawing.Size(100, 28);
            this.btnExportLaporanPemasukan.TabIndex = 17;
            this.btnExportLaporanPemasukan.Text = "Export";
            this.btnExportLaporanPemasukan.UseVisualStyleBackColor = true;
            this.btnExportLaporanPemasukan.Click += new System.EventHandler(this.btnExportLaporanPemasukan_Click);
            // 
            // btnRefreshDataPemasukan
            // 
            this.btnRefreshDataPemasukan.Location = new System.Drawing.Point(1069, 29);
            this.btnRefreshDataPemasukan.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshDataPemasukan.Name = "btnRefreshDataPemasukan";
            this.btnRefreshDataPemasukan.Size = new System.Drawing.Size(100, 28);
            this.btnRefreshDataPemasukan.TabIndex = 16;
            this.btnRefreshDataPemasukan.Text = "Refresh";
            this.btnRefreshDataPemasukan.UseVisualStyleBackColor = true;
            // 
            // btnCariLaporanPengeluaran
            // 
            this.btnCariLaporanPengeluaran.Location = new System.Drawing.Point(961, 29);
            this.btnCariLaporanPengeluaran.Margin = new System.Windows.Forms.Padding(4);
            this.btnCariLaporanPengeluaran.Name = "btnCariLaporanPengeluaran";
            this.btnCariLaporanPengeluaran.Size = new System.Drawing.Size(100, 28);
            this.btnCariLaporanPengeluaran.TabIndex = 15;
            this.btnCariLaporanPengeluaran.Text = "Cari";
            this.btnCariLaporanPengeluaran.UseVisualStyleBackColor = true;
            // 
            // FrmLaporanPemasukan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 555);
            this.Controls.Add(this.btnExportLaporanPemasukan);
            this.Controls.Add(this.btnRefreshDataPemasukan);
            this.Controls.Add(this.btnCariLaporanPengeluaran);
            this.Controls.Add(this.txtCariPemasukan);
            this.Controls.Add(this.lsvLaporanPemasukan);
            this.Controls.Add(this.btnTambahPemasukan);
            this.Controls.Add(this.btnPerbaikiPemasukan);
            this.Controls.Add(this.btnHapusPemasukan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLaporanPemasukan";
            this.Text = "FrmPemasukan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnHapusPemasukan;
        private System.Windows.Forms.Button btnPerbaikiPemasukan;
        private System.Windows.Forms.Button btnTambahPemasukan;
        private System.Windows.Forms.ListView lsvLaporanPemasukan;
        private System.Windows.Forms.TextBox txtCariPemasukan;
        private System.Windows.Forms.Button btnExportLaporanPemasukan;
        private System.Windows.Forms.Button btnRefreshDataPemasukan;
        private System.Windows.Forms.Button btnCariLaporanPengeluaran;
    }
}