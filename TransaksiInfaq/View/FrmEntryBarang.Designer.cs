namespace TransaksiInfaq.View
{
    partial class FrmEntryBarang
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
            this.btnSelesaiBarang = new System.Windows.Forms.Button();
            this.btnSimpanBarang = new System.Windows.Forms.Button();
            this.txtHargaBarang = new System.Windows.Forms.TextBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelesaiBarang
            // 
            this.btnSelesaiBarang.Location = new System.Drawing.Point(155, 149);
            this.btnSelesaiBarang.Name = "btnSelesaiBarang";
            this.btnSelesaiBarang.Size = new System.Drawing.Size(100, 23);
            this.btnSelesaiBarang.TabIndex = 24;
            this.btnSelesaiBarang.Text = "Selesai";
            this.btnSelesaiBarang.UseVisualStyleBackColor = true;
            this.btnSelesaiBarang.Click += new System.EventHandler(this.btnSelesaiBarang_Click);
            // 
            // btnSimpanBarang
            // 
            this.btnSimpanBarang.Location = new System.Drawing.Point(49, 149);
            this.btnSimpanBarang.Name = "btnSimpanBarang";
            this.btnSimpanBarang.Size = new System.Drawing.Size(100, 23);
            this.btnSimpanBarang.TabIndex = 23;
            this.btnSimpanBarang.Text = "Simpan";
            this.btnSimpanBarang.UseVisualStyleBackColor = true;
            this.btnSimpanBarang.Click += new System.EventHandler(this.btnSimpanBarang_Click);
            // 
            // txtHargaBarang
            // 
            this.txtHargaBarang.Location = new System.Drawing.Point(110, 101);
            this.txtHargaBarang.Name = "txtHargaBarang";
            this.txtHargaBarang.Size = new System.Drawing.Size(145, 20);
            this.txtHargaBarang.TabIndex = 22;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(110, 60);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(145, 20);
            this.txtNamaBarang.TabIndex = 21;
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Location = new System.Drawing.Point(110, 23);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(145, 20);
            this.txtKodeBarang.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Harga";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nama Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Kode Barang";
            // 
            // FrmEntryBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 192);
            this.Controls.Add(this.btnSelesaiBarang);
            this.Controls.Add(this.btnSimpanBarang);
            this.Controls.Add(this.txtHargaBarang);
            this.Controls.Add(this.txtNamaBarang);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "FrmEntryBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmEntryBarang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelesaiBarang;
        private System.Windows.Forms.Button btnSimpanBarang;
        private System.Windows.Forms.TextBox txtHargaBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}