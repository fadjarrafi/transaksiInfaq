namespace TransaksiInfaq.View
{
    partial class FrmUtamaPengeluaran
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
            this.btnKembaliPengeluaran = new System.Windows.Forms.Button();
            this.tbpBarang = new System.Windows.Forms.TabPage();
            this.tbpDetailKeluar = new System.Windows.Forms.TabPage();
            this.tbpPengeluaran = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKembaliPengeluaran
            // 
            this.btnKembaliPengeluaran.Location = new System.Drawing.Point(12, 461);
            this.btnKembaliPengeluaran.Name = "btnKembaliPengeluaran";
            this.btnKembaliPengeluaran.Size = new System.Drawing.Size(119, 23);
            this.btnKembaliPengeluaran.TabIndex = 14;
            this.btnKembaliPengeluaran.Text = "Kembali";
            this.btnKembaliPengeluaran.UseVisualStyleBackColor = true;
            this.btnKembaliPengeluaran.Click += new System.EventHandler(this.btnKembaliPengeluaran_Click);
            // 
            // tbpBarang
            // 
            this.tbpBarang.Location = new System.Drawing.Point(4, 22);
            this.tbpBarang.Name = "tbpBarang";
            this.tbpBarang.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBarang.Size = new System.Drawing.Size(958, 429);
            this.tbpBarang.TabIndex = 3;
            this.tbpBarang.Text = "Barang";
            this.tbpBarang.UseVisualStyleBackColor = true;
            // 
            // tbpDetailKeluar
            // 
            this.tbpDetailKeluar.Location = new System.Drawing.Point(4, 22);
            this.tbpDetailKeluar.Name = "tbpDetailKeluar";
            this.tbpDetailKeluar.Padding = new System.Windows.Forms.Padding(3);
            this.tbpDetailKeluar.Size = new System.Drawing.Size(958, 429);
            this.tbpDetailKeluar.TabIndex = 2;
            this.tbpDetailKeluar.Text = "Detail Keluar";
            this.tbpDetailKeluar.UseVisualStyleBackColor = true;
            // 
            // tbpPengeluaran
            // 
            this.tbpPengeluaran.Location = new System.Drawing.Point(4, 22);
            this.tbpPengeluaran.Name = "tbpPengeluaran";
            this.tbpPengeluaran.Padding = new System.Windows.Forms.Padding(3);
            this.tbpPengeluaran.Size = new System.Drawing.Size(958, 429);
            this.tbpPengeluaran.TabIndex = 0;
            this.tbpPengeluaran.Text = "Laporan Pengeluaran";
            this.tbpPengeluaran.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpPengeluaran);
            this.tabControl1.Controls.Add(this.tbpDetailKeluar);
            this.tabControl1.Controls.Add(this.tbpBarang);
            this.tabControl1.Location = new System.Drawing.Point(1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 455);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // FrmUtamaPengeluaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 495);
            this.Controls.Add(this.btnKembaliPengeluaran);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmUtamaPengeluaran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPengeluaran";
            this.Shown += new System.EventHandler(this.FrmUtamaPengeluaran_Shown);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKembaliPengeluaran;
        private System.Windows.Forms.TabPage tbpBarang;
        private System.Windows.Forms.TabPage tbpDetailKeluar;
        private System.Windows.Forms.TabPage tbpPengeluaran;
        private System.Windows.Forms.TabControl tabControl1;
    }
}