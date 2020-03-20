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
    public partial class FrmDataPengurus : Form
    {
        private List<Pengurus> listOfPengurus = new List<Pengurus>();

        private PengurusController controller;

        public FrmDataPengurus()
        {
            InitializeComponent();
            controller = new PengurusController();
            InisialisasiListView();
            LoadDataPengurus();
        }

        private void InisialisasiListView()
        {
            lvwDataPengurus.View = System.Windows.Forms.View.Details;
            lvwDataPengurus.FullRowSelect = true;
            lvwDataPengurus.GridLines = true;

            lvwDataPengurus.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwDataPengurus.Columns.Add("Kode Pengurus", 91, HorizontalAlignment.Center);
            lvwDataPengurus.Columns.Add("Nama", 110, HorizontalAlignment.Center);
            lvwDataPengurus.Columns.Add("Alamat", 110, HorizontalAlignment.Center);
            lvwDataPengurus.Columns.Add("No Telepon", 91, HorizontalAlignment.Center);

        }

        private void LoadDataPengurus()
        {
            // kosongkan listview
            lvwDataPengurus.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfPengurus = controller.ReadAll();

            // ekstrak objek prs dari collection
            foreach (var prs in listOfPengurus)
            {
                var noUrut = lvwDataPengurus.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(prs.Kode_Pengurus);
                item.SubItems.Add(prs.Nama);
                item.SubItems.Add(prs.Alamat);
                item.SubItems.Add(prs.No_Telepon);
                item.SubItems.Add(prs.Username);
                item.SubItems.Add(prs.Password);

                // tampilkan data prs ke listview
                lvwDataPengurus.Items.Add(item);
            }

        }

        // method event handler untuk merespon event OnCreate,
        private void OnCreateEventHandler(Pengurus prs)
        {
            // tambahkan objek prs yang baru ke dalam collection
            listOfPengurus.Add(prs);

            int noUrut = lvwDataPengurus.Items.Count + 1;

            // tampilkan data prs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(prs.Kode_Pengurus);
            item.SubItems.Add(prs.Nama);
            item.SubItems.Add(prs.Alamat);
            item.SubItems.Add(prs.No_Telepon);
            item.SubItems.Add(prs.Username);
            item.SubItems.Add(prs.Password);

            lvwDataPengurus.Items.Add(item);
        }

        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Pengurus prs)
        {
            // ambil index data prs yang edit
            int index = lvwDataPengurus.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = lvwDataPengurus.Items[index];
            itemRow.SubItems[1].Text = prs.Kode_Pengurus;
            itemRow.SubItems[2].Text = prs.Nama; 
            itemRow.SubItems[3].Text = prs.Alamat;
            itemRow.SubItems[4].Text = prs.No_Telepon;
            itemRow.SubItems[5].Text = prs.Username;
            itemRow.SubItems[6].Text = prs.Password;
        }



        private void btnKembaliDataPengurus_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmMainMenu frmMainMenu = new FrmMainMenu();
            frmMainMenu.ShowDialog();
        }

        private void btnCariDataPengurus_Click(object sender, EventArgs e)
        {
            if (txtCariDataPengurus.Text != "")
            {
                for (int i = lvwDataPengurus.Items.Count - 1; i >= 0; i--)
                {
                    var item = lvwDataPengurus.Items[i];
                    if (item.Text.ToLower().Contains(txtCariDataPengurus.Text.ToLower()))
                    {
                        item.BackColor = SystemColors.Highlight;
                        item.ForeColor = SystemColors.HighlightText;
                    }
                    else
                    {
                        lvwDataPengurus.Items.Remove(item);
                    }
                }
                if (lvwDataPengurus.SelectedItems.Count == 1)
                {
                    lvwDataPengurus.Focus();
                }
            }
            else if (txtCariDataPengurus.Text == "")
            {
                LoadDataPengurus();
            }
                

        }

        private void BtnTambahDataPengurus_Click_1(object sender, EventArgs e)
        {
            FrmEntryDataPengurus frmEntry = new FrmEntryDataPengurus("Tambah Data Pengurus", controller);

            // mendaftarkan method event handler untuk merespon event OnCreate
            frmEntry.OnCreate += OnCreateEventHandler;

            // tampilkan form entry mahasiswa
            frmEntry.ShowDialog();
        }

        private void BtnPerbaikiDataPengurus_Click_1(object sender, EventArgs e)
        {
            if (lvwDataPengurus.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Pengurus prs = listOfPengurus[lvwDataPengurus.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FrmEntryDataPengurus frmEntry = new FrmEntryDataPengurus("Edit Data Pengurus", prs, controller);

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

        private void BtnHapus_Click_1(object sender, EventArgs e)
        {
            if (lvwDataPengurus.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data pengurus ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Pengurus prs = listOfPengurus[lvwDataPengurus.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = controller.Delete(prs);
                    if (result > 0) LoadDataPengurus();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data pengurus belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCariDataPengurus_TextChanged(object sender, EventArgs e)
        {
            lvwDataPengurus.Items.Clear();

            listOfPengurus = controller.ReadByNama(txtCariDataPengurus.Text);

            foreach (var prs in listOfPengurus)
            {
                var noUrut = lvwDataPengurus.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(prs.Kode_Pengurus);
                item.SubItems.Add(prs.Nama);
                item.SubItems.Add(prs.Alamat);
                item.SubItems.Add(prs.No_Telepon);
                item.SubItems.Add(prs.Username);
                item.SubItems.Add(prs.Password);

                lvwDataPengurus.Items.Add(item);
            }
        }
    }
}
