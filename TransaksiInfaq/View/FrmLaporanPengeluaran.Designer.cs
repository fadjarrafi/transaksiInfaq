namespace TransaksiInfaq.View
{
    partial class FrmLaporanPengeluaran
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
            this.txtCariLaporanPengeluaran = new System.Windows.Forms.TextBox();
            this.btnExportLaporanPengeluaran = new System.Windows.Forms.Button();
            this.btnRefreshDataPengeluaran = new System.Windows.Forms.Button();
            this.btnCariLaporanPengeluaran = new System.Windows.Forms.Button();
            this.lsvLaporanPengeluaran = new System.Windows.Forms.ListView();
            this.btnTambahPengeluaran = new System.Windows.Forms.Button();
            this.btnPerbaikiPengeluaran = new System.Windows.Forms.Button();
            this.btnHapusPengeluaran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCariLaporanPengeluaran
            // 
            this.txtCariLaporanPengeluaran.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariLaporanPengeluaran.Location = new System.Drawing.Point(4, 39);
            this.txtCariLaporanPengeluaran.Margin = new System.Windows.Forms.Padding(4);
            this.txtCariLaporanPengeluaran.Name = "txtCariLaporanPengeluaran";
            this.txtCariLaporanPengeluaran.Size = new System.Drawing.Size(930, 23);
            this.txtCariLaporanPengeluaran.TabIndex = 15;
            this.txtCariLaporanPengeluaran.Text = "Ketik no faktur";
            this.txtCariLaporanPengeluaran.TextChanged += new System.EventHandler(this.txtCariLaporanPengeluaran_TextChanged);
            // 
            // btnExportLaporanPengeluaran
            // 
            this.btnExportLaporanPengeluaran.Location = new System.Drawing.Point(1158, 39);
            this.btnExportLaporanPengeluaran.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportLaporanPengeluaran.Name = "btnExportLaporanPengeluaran";
            this.btnExportLaporanPengeluaran.Size = new System.Drawing.Size(100, 28);
            this.btnExportLaporanPengeluaran.TabIndex = 14;
            this.btnExportLaporanPengeluaran.Text = "Export";
            this.btnExportLaporanPengeluaran.UseVisualStyleBackColor = true;
            this.btnExportLaporanPengeluaran.Click += new System.EventHandler(this.btnExportLaporanPengeluaran_Click);
            // 
            // btnRefreshDataPengeluaran
            // 
            this.btnRefreshDataPengeluaran.Location = new System.Drawing.Point(1050, 39);
            this.btnRefreshDataPengeluaran.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshDataPengeluaran.Name = "btnRefreshDataPengeluaran";
            this.btnRefreshDataPengeluaran.Size = new System.Drawing.Size(100, 28);
            this.btnRefreshDataPengeluaran.TabIndex = 13;
            this.btnRefreshDataPengeluaran.Text = "Refresh";
            this.btnRefreshDataPengeluaran.UseVisualStyleBackColor = true;
            // 
            // btnCariLaporanPengeluaran
            // 
            this.btnCariLaporanPengeluaran.Location = new System.Drawing.Point(942, 39);
            this.btnCariLaporanPengeluaran.Margin = new System.Windows.Forms.Padding(4);
            this.btnCariLaporanPengeluaran.Name = "btnCariLaporanPengeluaran";
            this.btnCariLaporanPengeluaran.Size = new System.Drawing.Size(100, 28);
            this.btnCariLaporanPengeluaran.TabIndex = 12;
            this.btnCariLaporanPengeluaran.Text = "Cari";
            this.btnCariLaporanPengeluaran.UseVisualStyleBackColor = true;
            // 
            // lsvLaporanPengeluaran
            // 
            this.lsvLaporanPengeluaran.HideSelection = false;
            this.lsvLaporanPengeluaran.Location = new System.Drawing.Point(4, 73);
            this.lsvLaporanPengeluaran.Margin = new System.Windows.Forms.Padding(4);
            this.lsvLaporanPengeluaran.Name = "lsvLaporanPengeluaran";
            this.lsvLaporanPengeluaran.Size = new System.Drawing.Size(1256, 409);
            this.lsvLaporanPengeluaran.TabIndex = 11;
            this.lsvLaporanPengeluaran.UseCompatibleStateImageBehavior = false;
            // 
            // btnTambahPengeluaran
            // 
            this.btnTambahPengeluaran.Location = new System.Drawing.Point(685, 490);
            this.btnTambahPengeluaran.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahPengeluaran.Name = "btnTambahPengeluaran";
            this.btnTambahPengeluaran.Size = new System.Drawing.Size(191, 28);
            this.btnTambahPengeluaran.TabIndex = 18;
            this.btnTambahPengeluaran.Text = "Tambah";
            this.btnTambahPengeluaran.UseVisualStyleBackColor = true;
            this.btnTambahPengeluaran.Click += new System.EventHandler(this.btnTambahPengeluaran_Click);
            // 
            // btnPerbaikiPengeluaran
            // 
            this.btnPerbaikiPengeluaran.Location = new System.Drawing.Point(884, 490);
            this.btnPerbaikiPengeluaran.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerbaikiPengeluaran.Name = "btnPerbaikiPengeluaran";
            this.btnPerbaikiPengeluaran.Size = new System.Drawing.Size(184, 28);
            this.btnPerbaikiPengeluaran.TabIndex = 17;
            this.btnPerbaikiPengeluaran.Text = "Perbaiki";
            this.btnPerbaikiPengeluaran.UseVisualStyleBackColor = true;
            this.btnPerbaikiPengeluaran.Click += new System.EventHandler(this.btnPerbaikiPengeluaran_Click);
            // 
            // btnHapusPengeluaran
            // 
            this.btnHapusPengeluaran.Location = new System.Drawing.Point(1076, 490);
            this.btnHapusPengeluaran.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapusPengeluaran.Name = "btnHapusPengeluaran";
            this.btnHapusPengeluaran.Size = new System.Drawing.Size(189, 28);
            this.btnHapusPengeluaran.TabIndex = 16;
            this.btnHapusPengeluaran.Text = "Hapus";
            this.btnHapusPengeluaran.UseVisualStyleBackColor = true;
            this.btnHapusPengeluaran.Click += new System.EventHandler(this.btnHapusPengeluaran_Click);
            // 
            // FrmLaporanPengeluaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 528);
            this.Controls.Add(this.btnTambahPengeluaran);
            this.Controls.Add(this.btnPerbaikiPengeluaran);
            this.Controls.Add(this.btnHapusPengeluaran);
            this.Controls.Add(this.txtCariLaporanPengeluaran);
            this.Controls.Add(this.btnExportLaporanPengeluaran);
            this.Controls.Add(this.btnRefreshDataPengeluaran);
            this.Controls.Add(this.btnCariLaporanPengeluaran);
            this.Controls.Add(this.lsvLaporanPengeluaran);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLaporanPengeluaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLaporanPengeluaran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCariLaporanPengeluaran;
        private System.Windows.Forms.Button btnExportLaporanPengeluaran;
        private System.Windows.Forms.Button btnRefreshDataPengeluaran;
        private System.Windows.Forms.Button btnCariLaporanPengeluaran;
        private System.Windows.Forms.ListView lsvLaporanPengeluaran;
        private System.Windows.Forms.Button btnTambahPengeluaran;
        private System.Windows.Forms.Button btnPerbaikiPengeluaran;
        private System.Windows.Forms.Button btnHapusPengeluaran;
    }
}