namespace TransaksiInfaq.View
{
    partial class FrmLaporanBarang
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
            this.btnExportBarang = new System.Windows.Forms.Button();
            this.btnRefreshBarang = new System.Windows.Forms.Button();
            this.lsvBarang = new System.Windows.Forms.ListView();
            this.TambahLaporanBarang = new System.Windows.Forms.Button();
            this.TambahPerbaikiLaporanBarang = new System.Windows.Forms.Button();
            this.TambahHapusLaporanBarang = new System.Windows.Forms.Button();
            this.txtCariBarang = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnExportBarang
            // 
            this.btnExportBarang.Location = new System.Drawing.Point(1104, 13);
            this.btnExportBarang.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportBarang.Name = "btnExportBarang";
            this.btnExportBarang.Size = new System.Drawing.Size(133, 28);
            this.btnExportBarang.TabIndex = 21;
            this.btnExportBarang.Text = "Export";
            this.btnExportBarang.UseVisualStyleBackColor = true;
            // 
            // btnRefreshBarang
            // 
            this.btnRefreshBarang.Location = new System.Drawing.Point(963, 13);
            this.btnRefreshBarang.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshBarang.Name = "btnRefreshBarang";
            this.btnRefreshBarang.Size = new System.Drawing.Size(133, 28);
            this.btnRefreshBarang.TabIndex = 20;
            this.btnRefreshBarang.Text = "Refresh";
            this.btnRefreshBarang.UseVisualStyleBackColor = true;
            // 
            // lsvBarang
            // 
            this.lsvBarang.HideSelection = false;
            this.lsvBarang.Location = new System.Drawing.Point(16, 50);
            this.lsvBarang.Margin = new System.Windows.Forms.Padding(4);
            this.lsvBarang.Name = "lsvBarang";
            this.lsvBarang.Size = new System.Drawing.Size(1239, 420);
            this.lsvBarang.TabIndex = 19;
            this.lsvBarang.UseCompatibleStateImageBehavior = false;
            // 
            // TambahLaporanBarang
            // 
            this.TambahLaporanBarang.Location = new System.Drawing.Point(675, 478);
            this.TambahLaporanBarang.Margin = new System.Windows.Forms.Padding(4);
            this.TambahLaporanBarang.Name = "TambahLaporanBarang";
            this.TambahLaporanBarang.Size = new System.Drawing.Size(191, 28);
            this.TambahLaporanBarang.TabIndex = 26;
            this.TambahLaporanBarang.Text = "Tambah";
            this.TambahLaporanBarang.UseVisualStyleBackColor = true;
            this.TambahLaporanBarang.Click += new System.EventHandler(this.TambahLaporanBarang_Click);
            // 
            // TambahPerbaikiLaporanBarang
            // 
            this.TambahPerbaikiLaporanBarang.Location = new System.Drawing.Point(874, 478);
            this.TambahPerbaikiLaporanBarang.Margin = new System.Windows.Forms.Padding(4);
            this.TambahPerbaikiLaporanBarang.Name = "TambahPerbaikiLaporanBarang";
            this.TambahPerbaikiLaporanBarang.Size = new System.Drawing.Size(184, 28);
            this.TambahPerbaikiLaporanBarang.TabIndex = 25;
            this.TambahPerbaikiLaporanBarang.Text = "Perbaiki";
            this.TambahPerbaikiLaporanBarang.UseVisualStyleBackColor = true;
            this.TambahPerbaikiLaporanBarang.Click += new System.EventHandler(this.TambahPerbaikiLaporanBarang_Click);
            // 
            // TambahHapusLaporanBarang
            // 
            this.TambahHapusLaporanBarang.Location = new System.Drawing.Point(1066, 478);
            this.TambahHapusLaporanBarang.Margin = new System.Windows.Forms.Padding(4);
            this.TambahHapusLaporanBarang.Name = "TambahHapusLaporanBarang";
            this.TambahHapusLaporanBarang.Size = new System.Drawing.Size(189, 28);
            this.TambahHapusLaporanBarang.TabIndex = 24;
            this.TambahHapusLaporanBarang.Text = "Hapus";
            this.TambahHapusLaporanBarang.UseVisualStyleBackColor = true;
            this.TambahHapusLaporanBarang.Click += new System.EventHandler(this.TambahHapusLaporanBarang_Click);
            // 
            // txtCariBarang
            // 
            this.txtCariBarang.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariBarang.Location = new System.Drawing.Point(16, 15);
            this.txtCariBarang.Name = "txtCariBarang";
            this.txtCariBarang.Size = new System.Drawing.Size(940, 23);
            this.txtCariBarang.TabIndex = 27;
            this.txtCariBarang.Text = "Ketik nama barang";
            this.txtCariBarang.TextChanged += new System.EventHandler(this.txtCariBarang_TextChanged);
            // 
            // FrmLaporanBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 531);
            this.Controls.Add(this.txtCariBarang);
            this.Controls.Add(this.TambahLaporanBarang);
            this.Controls.Add(this.TambahPerbaikiLaporanBarang);
            this.Controls.Add(this.TambahHapusLaporanBarang);
            this.Controls.Add(this.btnExportBarang);
            this.Controls.Add(this.btnRefreshBarang);
            this.Controls.Add(this.lsvBarang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLaporanBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLaporanBarang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportBarang;
        private System.Windows.Forms.Button btnRefreshBarang;
        private System.Windows.Forms.ListView lsvBarang;
        private System.Windows.Forms.Button TambahLaporanBarang;
        private System.Windows.Forms.Button TambahPerbaikiLaporanBarang;
        private System.Windows.Forms.Button TambahHapusLaporanBarang;
        private System.Windows.Forms.TextBox txtCariBarang;
    }
}