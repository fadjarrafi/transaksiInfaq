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
    public partial class FrmLaporanTabungan : Form
    {
        private List<Tabungan> listOfTabungan = new List<Tabungan>();

        private TabunganController tabunganController;

        public FrmLaporanTabungan()
        {
            InitializeComponent();
            InisialisasiListViewTabungan();
            tabunganController = new TabunganController();
            LoadDataTabungan();
        }

        private void InisialisasiListViewTabungan()
        {
            lsvTabungan.View = System.Windows.Forms.View.Details;
            lsvTabungan.FullRowSelect = true;
            lsvTabungan.GridLines = true;

            lsvTabungan.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lsvTabungan.Columns.Add("No Rekening", 91, HorizontalAlignment.Center);
            lsvTabungan.Columns.Add("Bank", 110, HorizontalAlignment.Center);
            lsvTabungan.Columns.Add("Saldo", 110, HorizontalAlignment.Center);

        }

        private void LoadDataTabungan()
        {
            // kosongkan listview
            lsvTabungan.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfTabungan = tabunganController.ReadAll();

            // ekstrak objek prs dari collection
            foreach (var tbg in listOfTabungan)
            {
                var noUrut = lsvTabungan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(tbg.No_rekening);
                item.SubItems.Add(tbg.Bank);
                item.SubItems.Add(tbg.Saldo);

                // tampilkan data prs ke listview
                lsvTabungan.Items.Add(item);
            }
        }

        private void OnCreateEventHandler(Tabungan tbg)
        {
            // tambahkan objek prs yang baru ke dalam collection
            listOfTabungan.Add(tbg);

            int noUrut = lsvTabungan.Items.Count + 1;

            // tampilkan data prs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(tbg.No_rekening);
            item.SubItems.Add(tbg.Bank);
            item.SubItems.Add(tbg.Saldo);

            lsvTabungan.Items.Add(item);
        }

        private void OnUpdateEventHandler(Tabungan tbg)
        {
            // ambil index data prs yang edit
            int index = lsvTabungan.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = lsvTabungan.Items[index];
            itemRow.SubItems[1].Text = tbg.No_rekening;
            itemRow.SubItems[2].Text = tbg.Bank;
            itemRow.SubItems[3].Text = tbg.Saldo;
        }

        private void btnTambahTabungan_Click(object sender, EventArgs e)
        {
            // buat objek form entry data mahasiswa
            FrmEntryTabungan frmEntry = new FrmEntryTabungan("Entry Data Pengurus", tabunganController);

            // mendaftarkan method event handler untuk merespon event OnUpdate
            frmEntry.OnCreate += OnCreateEventHandler;

            // tampilkan form entry mahasiswa
            frmEntry.ShowDialog();
        }

        private void btnPerbaikiTabungan_Click(object sender, EventArgs e)
        {
            if (lsvTabungan.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Tabungan tbg = listOfTabungan[lsvTabungan.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FrmEntryTabungan frmEntry = new FrmEntryTabungan("Edit Data Pengurus", tbg, tabunganController);

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

        private void btnHapusTabungan_Click(object sender, EventArgs e)
        {
            if (lsvTabungan.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data pengurus ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Tabungan tbg = listOfTabungan[lsvTabungan.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = tabunganController.Delete(tbg);
                    if (result > 0) LoadDataTabungan();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data pengurus belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lsvTabungan.Items.Clear();

            listOfTabungan = tabunganController.ReadByNoRekening(txtCariTabungan.Text);

            foreach (var tbg in listOfTabungan)
            {
                var noUrut = lsvTabungan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(tbg.No_rekening);
                item.SubItems.Add(tbg.Bank);
                item.SubItems.Add(tbg.Saldo);

                lsvTabungan.Items.Add(item);
            }
        }
    }
}
