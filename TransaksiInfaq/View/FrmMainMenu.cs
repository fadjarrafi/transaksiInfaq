using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TransaksiInfaq.View
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void BtnDataPengguna_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmDataPengurus frmDataPengurus = new FrmDataPengurus();
            frmDataPengurus.ShowDialog();
        }

        private void BtnPemasukan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPemasukan frmPemasukan = new FrmPemasukan();
            frmPemasukan.ShowDialog();
        }

        private void BtnPengeluaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmPengeluaran frmPengeluaran = new FrmPengeluaran();
            frmPengeluaran.ShowDialog();
        }
    }
}
