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
    public partial class FrmUtamaPengeluaran : Form
    {
        FrmLaporanPengeluaran frmLaporanPengeluaran = new FrmLaporanPengeluaran();
        FrmLaporanDetailKeluar frmLaporanDetailBarang = new FrmLaporanDetailKeluar();
        FrmLaporanBarang frmLaporanBarang = new FrmLaporanBarang();

        public FrmUtamaPengeluaran()
        {
            InitializeComponent();
            IndexSelected();
        }

        private void IndexSelected()
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tbpPengeluaran.Controls.Clear();
                frmLaporanPengeluaran.TopLevel = false;
                tbpPengeluaran.Controls.Add(frmLaporanPengeluaran);
                frmLaporanPengeluaran.Show();


            }
            else if (tabControl1.SelectedIndex == 1)
            {
                tbpDetailKeluar.Controls.Clear();
                frmLaporanDetailBarang.TopLevel = false;
                tbpDetailKeluar.Controls.Add(frmLaporanDetailBarang);
                frmLaporanDetailBarang.Show();
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                tbpBarang.Controls.Clear();
                frmLaporanBarang.TopLevel = false;
                tbpBarang.Controls.Add(frmLaporanBarang);
                frmLaporanBarang.Show();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            IndexSelected();
        }

        private void btnKembaliPengeluaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.ShowDialog();
        }

        private void FrmUtamaPengeluaran_Shown(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }
    }
}
