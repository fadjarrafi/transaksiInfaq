namespace TransaksiInfaq.View
{
    partial class FrmLaporanTabungan
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
            this.btnTambahTabungan = new System.Windows.Forms.Button();
            this.btnPerbaikiTabungan = new System.Windows.Forms.Button();
            this.btnHapusTabungan = new System.Windows.Forms.Button();
            this.lsvTabungan = new System.Windows.Forms.ListView();
            this.txtCariTabungan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTambahTabungan
            // 
            this.btnTambahTabungan.Location = new System.Drawing.Point(699, 508);
            this.btnTambahTabungan.Margin = new System.Windows.Forms.Padding(4);
            this.btnTambahTabungan.Name = "btnTambahTabungan";
            this.btnTambahTabungan.Size = new System.Drawing.Size(191, 28);
            this.btnTambahTabungan.TabIndex = 6;
            this.btnTambahTabungan.Text = "Tambah";
            this.btnTambahTabungan.UseVisualStyleBackColor = true;
            this.btnTambahTabungan.Click += new System.EventHandler(this.btnTambahTabungan_Click);
            // 
            // btnPerbaikiTabungan
            // 
            this.btnPerbaikiTabungan.Location = new System.Drawing.Point(897, 508);
            this.btnPerbaikiTabungan.Margin = new System.Windows.Forms.Padding(4);
            this.btnPerbaikiTabungan.Name = "btnPerbaikiTabungan";
            this.btnPerbaikiTabungan.Size = new System.Drawing.Size(184, 28);
            this.btnPerbaikiTabungan.TabIndex = 5;
            this.btnPerbaikiTabungan.Text = "Perbaiki";
            this.btnPerbaikiTabungan.UseVisualStyleBackColor = true;
            this.btnPerbaikiTabungan.Click += new System.EventHandler(this.btnPerbaikiTabungan_Click);
            // 
            // btnHapusTabungan
            // 
            this.btnHapusTabungan.Location = new System.Drawing.Point(1089, 508);
            this.btnHapusTabungan.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapusTabungan.Name = "btnHapusTabungan";
            this.btnHapusTabungan.Size = new System.Drawing.Size(189, 28);
            this.btnHapusTabungan.TabIndex = 4;
            this.btnHapusTabungan.Text = "Hapus";
            this.btnHapusTabungan.UseVisualStyleBackColor = true;
            this.btnHapusTabungan.Click += new System.EventHandler(this.btnHapusTabungan_Click);
            // 
            // lsvTabungan
            // 
            this.lsvTabungan.HideSelection = false;
            this.lsvTabungan.Location = new System.Drawing.Point(3, 69);
            this.lsvTabungan.Margin = new System.Windows.Forms.Padding(4);
            this.lsvTabungan.Name = "lsvTabungan";
            this.lsvTabungan.Size = new System.Drawing.Size(1276, 431);
            this.lsvTabungan.TabIndex = 7;
            this.lsvTabungan.UseCompatibleStateImageBehavior = false;
            // 
            // txtCariTabungan
            // 
            this.txtCariTabungan.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCariTabungan.Location = new System.Drawing.Point(3, 40);
            this.txtCariTabungan.Name = "txtCariTabungan";
            this.txtCariTabungan.Size = new System.Drawing.Size(707, 23);
            this.txtCariTabungan.TabIndex = 8;
            this.txtCariTabungan.Text = "Ketik no rekening";
            this.txtCariTabungan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FrmLaporanTabungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 555);
            this.Controls.Add(this.txtCariTabungan);
            this.Controls.Add(this.lsvTabungan);
            this.Controls.Add(this.btnTambahTabungan);
            this.Controls.Add(this.btnPerbaikiTabungan);
            this.Controls.Add(this.btnHapusTabungan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLaporanTabungan";
            this.Text = "FrmTabungan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTambahTabungan;
        private System.Windows.Forms.Button btnPerbaikiTabungan;
        private System.Windows.Forms.Button btnHapusTabungan;
        private System.Windows.Forms.ListView lsvTabungan;
        private System.Windows.Forms.TextBox txtCariTabungan;
    }
}