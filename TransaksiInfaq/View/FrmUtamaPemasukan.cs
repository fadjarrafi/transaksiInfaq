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
    public partial class FrmUtamaPemasukan : Form
    {
        FrmLaporanPemasukan frmpemasukan = new FrmLaporanPemasukan();
        FrmLaporanTabungan frmtabungan = new FrmLaporanTabungan();
        public FrmUtamaPemasukan()
        {
            InitializeComponent();
            IndexSelected();
        }

        private void IndexSelected()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tbpPemasukan.Controls.Clear();
                frmpemasukan.TopLevel = false;
                tbpPemasukan.Controls.Add(frmpemasukan);
                frmpemasukan.Show();
                
                
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                tbpTabungan.Controls.Clear();
                frmtabungan.TopLevel = false;
                tbpTabungan.Controls.Add(frmtabungan);
                frmtabungan.Show();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            IndexSelected();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            IndexSelected();
        }

        private void btnKembaliPemasukan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.ShowDialog();
        }

        private void FrmUtamaPemasukan_Shown(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
    }
}
