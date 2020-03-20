using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransaksiInfaq.Model.Entity;
using TransaksiInfaq.Controller;


namespace TransaksiInfaq.View
{
    public partial class FrmLaporanDetailKeluar : Form
    {

        private List<Detail_Keluar> listOfDetailKeluar = new List<Detail_Keluar>();

        private Detail_KeluarController detailkeluarController;

        public FrmLaporanDetailKeluar()
        {
            InitializeComponent();
            detailkeluarController = new Detail_KeluarController();
            InisialisasiListViewDetail_Keluar();
            LoadDataDetail_Keluar();
        }

        private void InisialisasiListViewDetail_Keluar()
        {
            lsvDetailKeluar.View = System.Windows.Forms.View.Details;
            lsvDetailKeluar.FullRowSelect = true;
            lsvDetailKeluar.GridLines = true;

            lsvDetailKeluar.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lsvDetailKeluar.Columns.Add("No Faktur", 91, HorizontalAlignment.Center);
            lsvDetailKeluar.Columns.Add("Kode Barang", 110, HorizontalAlignment.Center);
            lsvDetailKeluar.Columns.Add("Jumlah", 110, HorizontalAlignment.Center);
        }

        private void LoadDataDetail_Keluar()
        {
            // kosongkan listview
            lsvDetailKeluar.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfDetailKeluar = detailkeluarController.ReadAll();

            // ekstrak objek prs dari collection
            foreach (var klr in listOfDetailKeluar)
            {
                var noUrut = lsvDetailKeluar.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(klr.No_Faktur);
                item.SubItems.Add(klr.Kode_Barang);
                item.SubItems.Add(klr.Jumlah);

                // tampilkan data prs ke listview
                lsvDetailKeluar.Items.Add(item);
            }
        }
        private void OnCreateEventHandler(Detail_Keluar klr)
        {
            // tambahkan objek prs yang baru ke dalam collection
            listOfDetailKeluar.Add(klr);

            int noUrut = lsvDetailKeluar.Items.Count + 1;

            // tampilkan data prs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(klr.No_Faktur);
            item.SubItems.Add(klr.Kode_Barang);
            item.SubItems.Add(klr.Jumlah);     

            lsvDetailKeluar.Items.Add(item);
        }

        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Detail_Keluar klr)
        {
            // ambil index data prs yang edit
            int index = lsvDetailKeluar.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = lsvDetailKeluar.Items[index];
            itemRow.SubItems[1].Text = klr.No_Faktur;
            itemRow.SubItems[2].Text = klr.Kode_Barang;
            itemRow.SubItems[3].Text = klr.Jumlah;
        }

        private void btnTambahLaporanDetailKeluar_Click(object sender, EventArgs e)
        {
                // buat objek form entry data mahasiswa
                FrmEntryDetailKeluar frmEntry = new FrmEntryDetailKeluar("Entry Data Pengurus", detailkeluarController);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnCreate += OnCreateEventHandler;

                // tampilkan form entry mahasiswa
                frmEntry.ShowDialog();
            
        }

        private void btnPerbaikiLaporanDetailKeluar_Click(object sender, EventArgs e)
        {
            if (lsvDetailKeluar.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Detail_Keluar klr = listOfDetailKeluar[lsvDetailKeluar.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FrmEntryDetailKeluar frmEntry = new FrmEntryDetailKeluar("Edit Data Pengurus", klr, detailkeluarController);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnUpdate += OnUpdateEventHandler;

                // tampilkan form entry mahasiswa
                frmEntry.ShowDialog();
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data belum dipilih", "Peringatan", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
            }
        }

        private void txtCariDetailKeluar_TextChanged(object sender, EventArgs e)
        {
            lsvDetailKeluar.Items.Clear();

            listOfDetailKeluar = detailkeluarController.ReadByNoFaktur(txtCariDetailKeluar.Text);

            foreach (var dtl in listOfDetailKeluar)
            {
                var noUrut = lsvDetailKeluar.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(dtl.No_Faktur);
                item.SubItems.Add(dtl.Kode_Barang);
                item.SubItems.Add(dtl.Jumlah);

                lsvDetailKeluar.Items.Add(item);
            }
        }
    }
}
