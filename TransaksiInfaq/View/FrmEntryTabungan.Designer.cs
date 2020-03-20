namespace TransaksiInfaq.View
{
    partial class FrmEntryTabungan
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelesaiTabungan = new System.Windows.Forms.Button();
            this.btnSimpanTabungan = new System.Windows.Forms.Button();
            this.txtSaldoPemasukan = new System.Windows.Forms.TextBox();
            this.txtBankPemasukan = new System.Windows.Forms.TextBox();
            this.txtNoRekeningTabungan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSelesaiTabungan);
            this.groupBox2.Controls.Add(this.btnSimpanTabungan);
            this.groupBox2.Controls.Add(this.txtSaldoPemasukan);
            this.groupBox2.Controls.Add(this.txtBankPemasukan);
            this.groupBox2.Controls.Add(this.txtNoRekeningTabungan);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 301);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tabungan";
            // 
            // btnSelesaiTabungan
            // 
            this.btnSelesaiTabungan.Location = new System.Drawing.Point(257, 255);
            this.btnSelesaiTabungan.Name = "btnSelesaiTabungan";
            this.btnSelesaiTabungan.Size = new System.Drawing.Size(103, 23);
            this.btnSelesaiTabungan.TabIndex = 51;
            this.btnSelesaiTabungan.Text = "Selesai";
            this.btnSelesaiTabungan.UseVisualStyleBackColor = true;
            // 
            // btnSimpanTabungan
            // 
            this.btnSimpanTabungan.Location = new System.Drawing.Point(144, 255);
            this.btnSimpanTabungan.Name = "btnSimpanTabungan";
            this.btnSimpanTabungan.Size = new System.Drawing.Size(103, 23);
            this.btnSimpanTabungan.TabIndex = 50;
            this.btnSimpanTabungan.Text = "Simpan";
            this.btnSimpanTabungan.UseVisualStyleBackColor = true;
            this.btnSimpanTabungan.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtSaldoPemasukan
            // 
            this.txtSaldoPemasukan.Location = new System.Drawing.Point(227, 119);
            this.txtSaldoPemasukan.Name = "txtSaldoPemasukan";
            this.txtSaldoPemasukan.Size = new System.Drawing.Size(133, 20);
            this.txtSaldoPemasukan.TabIndex = 49;
            // 
            // txtBankPemasukan
            // 
            this.txtBankPemasukan.Location = new System.Drawing.Point(227, 78);
            this.txtBankPemasukan.Name = "txtBankPemasukan";
            this.txtBankPemasukan.Size = new System.Drawing.Size(133, 20);
            this.txtBankPemasukan.TabIndex = 48;
            // 
            // txtNoRekeningTabungan
            // 
            this.txtNoRekeningTabungan.Location = new System.Drawing.Point(227, 34);
            this.txtNoRekeningTabungan.Name = "txtNoRekeningTabungan";
            this.txtNoRekeningTabungan.Size = new System.Drawing.Size(133, 20);
            this.txtNoRekeningTabungan.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Saldo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "Bank";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "No Rekening";
            // 
            // FrmEntryTabungan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 330);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmEntryTabungan";
            this.Text = "FrmEntryTabungan";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelesaiTabungan;
        private System.Windows.Forms.Button btnSimpanTabungan;
        private System.Windows.Forms.TextBox txtSaldoPemasukan;
        private System.Windows.Forms.TextBox txtBankPemasukan;
        private System.Windows.Forms.TextBox txtNoRekeningTabungan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}