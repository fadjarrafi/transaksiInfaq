namespace TransaksiInfaq
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPemasukan = new System.Windows.Forms.Button();
            this.btnPengeluaran = new System.Windows.Forms.Button();
            this.btnDataPengguna = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 233);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(226, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Infaq Transaction Record System";
            // 
            // btnPemasukan
            // 
            this.btnPemasukan.Location = new System.Drawing.Point(487, 207);
            this.btnPemasukan.Name = "btnPemasukan";
            this.btnPemasukan.Size = new System.Drawing.Size(147, 72);
            this.btnPemasukan.TabIndex = 2;
            this.btnPemasukan.Text = "Pemasukan";
            this.btnPemasukan.UseVisualStyleBackColor = true;
            this.btnPemasukan.Click += new System.EventHandler(this.BtnPemasukan_Click);
            // 
            // btnPengeluaran
            // 
            this.btnPengeluaran.Location = new System.Drawing.Point(487, 285);
            this.btnPengeluaran.Name = "btnPengeluaran";
            this.btnPengeluaran.Size = new System.Drawing.Size(147, 72);
            this.btnPengeluaran.TabIndex = 3;
            this.btnPengeluaran.Text = " Pengeluaran";
            this.btnPengeluaran.UseVisualStyleBackColor = true;
            this.btnPengeluaran.Click += new System.EventHandler(this.BtnPengeluaran_Click);
            // 
            // btnDataPengguna
            // 
            this.btnDataPengguna.Location = new System.Drawing.Point(487, 129);
            this.btnDataPengguna.Name = "btnDataPengguna";
            this.btnDataPengguna.Size = new System.Drawing.Size(147, 72);
            this.btnDataPengguna.TabIndex = 4;
            this.btnDataPengguna.Text = "Data Pengurus";
            this.btnDataPengguna.UseVisualStyleBackColor = true;
            this.btnDataPengguna.Click += new System.EventHandler(this.BtnDataPengguna_Click);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDataPengguna);
            this.Controls.Add(this.btnPengeluaran);
            this.Controls.Add(this.btnPemasukan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmMainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPemasukan;
        private System.Windows.Forms.Button btnPengeluaran;
        private System.Windows.Forms.Button btnDataPengguna;
    }
}