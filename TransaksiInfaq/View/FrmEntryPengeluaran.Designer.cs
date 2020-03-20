namespace TransaksiInfaq.View
{
    partial class FrmEntryPengeluaran
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
            this.txtKodePengurusPengeluaran = new System.Windows.Forms.TextBox();
            this.txtRekeningPengeluaran = new System.Windows.Forms.TextBox();
            this.txtKeperluanPengeluaran = new System.Windows.Forms.TextBox();
            this.txtTotalPengeluaran = new System.Windows.Forms.TextBox();
            this.txtFakturPengeluaran = new System.Windows.Forms.TextBox();
            this.btnSimpanPengeluaran = new System.Windows.Forms.Button();
            this.dtpTanggalPengeluaran = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelesaiPengeluaran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtKodePengurusPengeluaran
            // 
            this.txtKodePengurusPengeluaran.Location = new System.Drawing.Point(213, 107);
            this.txtKodePengurusPengeluaran.Name = "txtKodePengurusPengeluaran";
            this.txtKodePengurusPengeluaran.Size = new System.Drawing.Size(133, 20);
            this.txtKodePengurusPengeluaran.TabIndex = 45;
            // 
            // txtRekeningPengeluaran
            // 
            this.txtRekeningPengeluaran.Location = new System.Drawing.Point(213, 232);
            this.txtRekeningPengeluaran.Name = "txtRekeningPengeluaran";
            this.txtRekeningPengeluaran.Size = new System.Drawing.Size(133, 20);
            this.txtRekeningPengeluaran.TabIndex = 43;
            // 
            // txtKeperluanPengeluaran
            // 
            this.txtKeperluanPengeluaran.Location = new System.Drawing.Point(213, 192);
            this.txtKeperluanPengeluaran.Name = "txtKeperluanPengeluaran";
            this.txtKeperluanPengeluaran.Size = new System.Drawing.Size(133, 20);
            this.txtKeperluanPengeluaran.TabIndex = 42;
            // 
            // txtTotalPengeluaran
            // 
            this.txtTotalPengeluaran.Location = new System.Drawing.Point(213, 150);
            this.txtTotalPengeluaran.Name = "txtTotalPengeluaran";
            this.txtTotalPengeluaran.Size = new System.Drawing.Size(133, 20);
            this.txtTotalPengeluaran.TabIndex = 41;
            // 
            // txtFakturPengeluaran
            // 
            this.txtFakturPengeluaran.Location = new System.Drawing.Point(213, 17);
            this.txtFakturPengeluaran.Name = "txtFakturPengeluaran";
            this.txtFakturPengeluaran.Size = new System.Drawing.Size(133, 20);
            this.txtFakturPengeluaran.TabIndex = 34;
            // 
            // btnSimpanPengeluaran
            // 
            this.btnSimpanPengeluaran.Location = new System.Drawing.Point(60, 304);
            this.btnSimpanPengeluaran.Name = "btnSimpanPengeluaran";
            this.btnSimpanPengeluaran.Size = new System.Drawing.Size(133, 23);
            this.btnSimpanPengeluaran.TabIndex = 47;
            this.btnSimpanPengeluaran.Text = "Simpan";
            this.btnSimpanPengeluaran.UseVisualStyleBackColor = true;
            this.btnSimpanPengeluaran.Click += new System.EventHandler(this.btnSimpanPengeluaran_Click);
            // 
            // dtpTanggalPengeluaran
            // 
            this.dtpTanggalPengeluaran.Location = new System.Drawing.Point(213, 65);
            this.dtpTanggalPengeluaran.Name = "dtpTanggalPengeluaran";
            this.dtpTanggalPengeluaran.Size = new System.Drawing.Size(133, 20);
            this.dtpTanggalPengeluaran.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 39;
            this.label6.Text = "Keperluan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 16);
            this.label5.TabIndex = 38;
            this.label5.Text = "Total Pengeluaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "No Rekening";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Kode Pengurus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "No Faktur";
            // 
            // btnSelesaiPengeluaran
            // 
            this.btnSelesaiPengeluaran.Location = new System.Drawing.Point(213, 304);
            this.btnSelesaiPengeluaran.Name = "btnSelesaiPengeluaran";
            this.btnSelesaiPengeluaran.Size = new System.Drawing.Size(133, 23);
            this.btnSelesaiPengeluaran.TabIndex = 50;
            this.btnSelesaiPengeluaran.Text = "Selesai";
            this.btnSelesaiPengeluaran.UseVisualStyleBackColor = true;
            this.btnSelesaiPengeluaran.Click += new System.EventHandler(this.btnSelesaiPengeluaran_Click);
            // 
            // FrmEntryPengeluaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 349);
            this.Controls.Add(this.btnSelesaiPengeluaran);
            this.Controls.Add(this.txtKodePengurusPengeluaran);
            this.Controls.Add(this.txtRekeningPengeluaran);
            this.Controls.Add(this.txtKeperluanPengeluaran);
            this.Controls.Add(this.txtTotalPengeluaran);
            this.Controls.Add(this.txtFakturPengeluaran);
            this.Controls.Add(this.btnSimpanPengeluaran);
            this.Controls.Add(this.dtpTanggalPengeluaran);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmEntryPengeluaran";
            this.Text = "FrmPengeluaran";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtKodePengurusPengeluaran;
        private System.Windows.Forms.TextBox txtRekeningPengeluaran;
        private System.Windows.Forms.TextBox txtKeperluanPengeluaran;
        private System.Windows.Forms.TextBox txtTotalPengeluaran;
        private System.Windows.Forms.TextBox txtFakturPengeluaran;
        private System.Windows.Forms.Button btnSimpanPengeluaran;
        private System.Windows.Forms.DateTimePicker dtpTanggalPengeluaran;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelesaiPengeluaran;
    }
}