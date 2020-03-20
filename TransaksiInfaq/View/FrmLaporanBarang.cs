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
    public partial class FrmLaporanBarang : Form
    {
        private List<Barang> listOfBarang = new List<Barang>();

        private BarangController barangController;
        public FrmLaporanBarang()
        {
            InitializeComponent();
            barangController = new BarangController();
            InisialisasiListViewBarang();
            LoadDataBarang();
        }

        private void InisialisasiListViewBarang()
        {
            lsvBarang.View = System.Windows.Forms.View.Details;
            lsvBarang.FullRowSelect = true;
            lsvBarang.GridLines = true;

            lsvBarang.Columns.Add("No", 35, HorizontalAlignment.Center);
            lsvBarang.Columns.Add("Kode Barang", 91, HorizontalAlignment.Center);
            lsvBarang.Columns.Add("Nama", 91, HorizontalAlignment.Center);
            lsvBarang.Columns.Add("Harga", 110, HorizontalAlignment.Center);
        }

        private void LoadDataBarang()
        {
            // kosongkan listview
            lsvBarang.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfBarang = barangController.ReadAll();

            // ekstrak objek prs dari collection
            foreach (var brg in listOfBarang)
            {
                var noUrut = lsvBarang.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(brg.Kode_Barang);
                item.SubItems.Add(brg.Nama_Barang);
                item.SubItems.Add(brg.Harga);

                // tampilkan data prs ke listview
                lsvBarang.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Barang brg)
        {
            // tambahkan objek prs yang baru ke dalam collection
            listOfBarang.Add(brg);

            int noUrut = lsvBarang.Items.Count + 1;

            // tampilkan data prs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(brg.Kode_Barang);
            item.SubItems.Add(brg.Nama_Barang);
            item.SubItems.Add(brg.Harga);
            

            lsvBarang.Items.Add(item);
        }

        private void OnUpdateEventHandler(Barang brg)
        {
            // ambil index data prs yang edit
            int index = lsvBarang.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = lsvBarang.Items[index];
            itemRow.SubItems[1].Text = brg.Kode_Barang;
            itemRow.SubItems[2].Text = brg.Nama_Barang;
            itemRow.SubItems[3].Text = brg.Harga;
        }

        private void TambahLaporanBarang_Click(object sender, EventArgs e)
        {
                // buat objek form entry data mahasiswa
                FrmEntryBarang frmEntry = new FrmEntryBarang("Entry Data Pengurus", barangController);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnCreate += OnCreateEventHandler;

                // tampilkan form entry mahasiswa
                frmEntry.ShowDialog();
        }

        private void TambahPerbaikiLaporanBarang_Click(object sender, EventArgs e)
        {
            if (lsvBarang.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Barang brg = listOfBarang[lsvBarang.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FrmEntryBarang frmEntry = new FrmEntryBarang("Edit Data Pengurus", brg, barangController);

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

        private void TambahHapusLaporanBarang_Click(object sender, EventArgs e)
        {
            if (lsvBarang.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data pengurus ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Barang brg = listOfBarang[lsvBarang.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = barangController.Delete(brg);
                    if (result > 0) LoadDataBarang();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data pengurus belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCariBarang_TextChanged(object sender, EventArgs e)
        {
            lsvBarang.Items.Clear();

            listOfBarang = barangController.ReadByNama(txtCariBarang.Text);

            foreach (var brg in listOfBarang)
            {
                var noUrut = lsvBarang.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(brg.Kode_Barang);
                item.SubItems.Add(brg.Nama_Barang);
                item.SubItems.Add(brg.Harga);

                lsvBarang.Items.Add(item);
            }
        }
    }
}