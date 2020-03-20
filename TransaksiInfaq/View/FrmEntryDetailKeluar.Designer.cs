namespace TransaksiInfaq.View
{
    partial class FrmEntryDetailKeluar
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
            this.btnSelesaiDetailKeluar = new System.Windows.Forms.Button();
            this.btnSimpanDetailKeluar = new System.Windows.Forms.Button();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.txtNoFaktur = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSelesaiDetailKeluar
            // 
            this.btnSelesaiDetailKeluar.Location = new System.Drawing.Point(147, 157);
            this.btnSelesaiDetailKeluar.Name = "btnSelesaiDetailKeluar";
            this.btnSelesaiDetailKeluar.Size = new System.Drawing.Size(100, 23);
            this.btnSelesaiDetailKeluar.TabIndex = 26;
            this.btnSelesaiDetailKeluar.Text = "Selesai";
            this.btnSelesaiDetailKeluar.UseVisualStyleBackColor = true;
            this.btnSelesaiDetailKeluar.Click += new System.EventHandler(this.btnSelesaiDetailKeluar_Click);
            // 
            // btnSimpanDetailKeluar
            // 
            this.btnSimpanDetailKeluar.Location = new System.Drawing.Point(41, 157);
            this.btnSimpanDetailKeluar.Name = "btnSimpanDetailKeluar";
            this.btnSimpanDetailKeluar.Size = new System.Drawing.Size(100, 23);
            this.btnSimpanDetailKeluar.TabIndex = 25;
            this.btnSimpanDetailKeluar.Text = "Simpan";
            this.btnSimpanDetailKeluar.UseVisualStyleBackColor = true;
            this.btnSimpanDetailKeluar.Click += new System.EventHandler(this.btnSimpanDetailKeluar_Click);
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(102, 119);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(145, 20);
            this.txtJumlah.TabIndex = 32;
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.Location = new System.Drawing.Point(102, 78);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(145, 20);
            this.txtKodeBarang.TabIndex = 31;
            // 
            // txtNoFaktur
            // 
            this.txtNoFaktur.Location = new System.Drawing.Point(102, 41);
            this.txtNoFaktur.Name = "txtNoFaktur";
            this.txtNoFaktur.Size = new System.Drawing.Size(145, 20);
            this.txtNoFaktur.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Jumlah";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "Kode Barang";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "No Faktur";
            // 
            // FrmEntryDetailKeluar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 192);
            this.Controls.Add(this.txtJumlah);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.txtNoFaktur);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnSelesaiDetailKeluar);
            this.Controls.Add(this.btnSimpanDetailKeluar);
            this.Name = "FrmEntryDetailKeluar";
            this.Text = "FrmEntryDetailKeluar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelesaiDetailKeluar;
        private System.Windows.Forms.Button btnSimpanDetailKeluar;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.TextBox txtNoFaktur;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}