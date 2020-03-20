namespace TransaksiInfaq.View
{
    partial class FrmDataPengurus
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
            this.btnKembaliDataPengurus = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnPerbaikiDataPengurus = new System.Windows.Forms.Button();
            this.btnTambahDataPengurus = new System.Windows.Forms.Button();
            this.lvwDataPengurus = new System.Windows.Forms.ListView();
            this.txtCariDataPengurus = new System.Windows.Forms.TextBox();
            this.btnCariDataPengurus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKembaliDataPengurus
            // 
            this.btnKembaliDataPengurus.Location = new System.Drawing.Point(12, 473);
            this.btnKembaliDataPengurus.Margin = new System.Windows.Forms.Padding(4);
            this.btnKembaliDataPengurus.Name = "btnKembaliDataPengurus";
            this.btnKembaliDataPengurus.Size = new System.Drawing.Size(168, 28);
            this.btnKembaliDataPengurus.TabIndex = 16;
            this.btnKembaliDataPengurus.Text = "Kembali";
            this.btnKembaliDataPengurus.UseVisualStyleBackColor = true;
            this.btnKembaliDataPengurus.Click += new System.EventHandler(this.btnKembaliDataPengurus_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Location = new System.Drawing.Point(885, 473);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(168, 28);
            this.btnHapus.TabIndex = 24;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.BtnHapus_Click_1);
            // 
            // btnPerbaikiDataPengurus
            // 
            this.btnPerbaikiDataPengurus.Location = new System.Drawing.Point(709, 473);
            this.btnPerbaikiDataPengurus.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerbaikiDataPengurus.Name = "btnPerbaikiDataPengurus";
            this.btnPerbaikiDataPengurus.Size = new System.Drawing.Size(168, 28);
            this.btnPerbaikiDataPengurus.TabIndex = 23;
            this.btnPerbaikiDataPengurus.Text = "Perbaiki";
            this.btnPerbaikiDataPengurus.UseVisualStyleBackColor = true;
            this.btnPerbaikiDataPengurus.Click += new System.EventHandler(this.BtnPerbaikiDataPengurus_Click_1);
            // 
            // btnTambahDataPengurus
            // 
            this.btnTambahDataPengurus.Location = new System.Drawing.Point(533, 473);
            this.btnTambahDataPengurus.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahDataPengurus.Name = "btnTambahDataPengurus";
            this.btnTambahDataPengurus.Size = new System.Drawing.Size(168, 28);
            this.btnTambahDataPengurus.TabIndex = 22;
            this.btnTambahDataPengurus.Text = "Tambah";
            this.btnTambahDataPengurus.UseVisualStyleBackColor = true;
            this.btnTambahDataPengurus.Click += new System.EventHandler(this.BtnTambahDataPengurus_Click_1);
            // 
            // lvwDataPengurus
            // 
            this.lvwDataPengurus.HideSelection = false;
            this.lvwDataPengurus.Location = new System.Drawing.Point(13, 106);
            this.lvwDataPengurus.Margin = new System.Windows.Forms.Padding(4);
            this.lvwDataPengurus.Name = "lvwDataPengurus";
            this.lvwDataPengurus.Size = new System.Drawing.Size(1037, 358);
            this.lvwDataPengurus.TabIndex = 20;
            this.lvwDataPengurus.UseCompatibleStateImageBehavior = false;
            // 
            // txtCariDataPengurus
            // 
            this.txtCariDataPengurus.BackColor = System.Drawing.SystemColors.Window;
            this.txtCariDataPengurus.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariDataPengurus.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtCariDataPengurus.Location = new System.Drawing.Point(13, 68);
            this.txtCariDataPengurus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCariDataPengurus.Name = "txtCariDataPengurus";
            this.txtCariDataPengurus.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCariDataPengurus.Size = new System.Drawing.Size(921, 23);
            this.txtCariDataPengurus.TabIndex = 25;
            this.txtCariDataPengurus.Text = "ketik nama pengurus yang ingin di cari";
            this.txtCariDataPengurus.TextChanged += new System.EventHandler(this.txtCariDataPengurus_TextChanged);
            // 
            // btnCariDataPengurus
            // 
            this.btnCariDataPengurus.Location = new System.Drawing.Point(941, 67);
            this.btnCariDataPengurus.Margin = new System.Windows.Forms.Padding(4);
            this.btnCariDataPengurus.Name = "btnCariDataPengurus";
            this.btnCariDataPengurus.Size = new System.Drawing.Size(109, 25);
            this.btnCariDataPengurus.TabIndex = 26;
            this.btnCariDataPengurus.Text = "Cari ";
            this.btnCariDataPengurus.UseVisualStyleBackColor = true;
            this.btnCariDataPengurus.Click += new System.EventHandler(this.btnCariDataPengurus_Click);
            // 
            // FrmDataPengurus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 519);
            this.Controls.Add(this.btnCariDataPengurus);
            this.Controls.Add(this.txtCariDataPengurus);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnPerbaikiDataPengurus);
            this.Controls.Add(this.btnTambahDataPengurus);
            this.Controls.Add(this.lvwDataPengurus);
            this.Controls.Add(this.btnKembaliDataPengurus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDataPengurus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDataPengurus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKembaliDataPengurus;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnPerbaikiDataPengurus;
        private System.Windows.Forms.Button btnTambahDataPengurus;
        private System.Windows.Forms.ListView lvwDataPengurus;
        private System.Windows.Forms.TextBox txtCariDataPengurus;
        private System.Windows.Forms.Button btnCariDataPengurus;
    }
}