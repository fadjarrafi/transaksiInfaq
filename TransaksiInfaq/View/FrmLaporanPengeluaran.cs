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
using Microsoft.Office.Interop.Excel;

namespace TransaksiInfaq.View
{
    public partial class FrmLaporanPengeluaran : Form
    {

        private List<Pengeluaran> listOfPengeluaran = new List<Pengeluaran>();

        private PengeluaranController pengeluaranController;

        public FrmLaporanPengeluaran()
        {
            InitializeComponent();
            pengeluaranController = new PengeluaranController();
            InisialisasiListViewPengeluaran();
            LoadDataPengeluaran();
        }

        private void InisialisasiListViewPengeluaran()
        {
            lsvLaporanPengeluaran.View = System.Windows.Forms.View.Details;
            lsvLaporanPengeluaran.FullRowSelect = true;
            lsvLaporanPengeluaran.GridLines = true;

            lsvLaporanPengeluaran.Columns.Add("No", 35, HorizontalAlignment.Center);
            lsvLaporanPengeluaran.Columns.Add("No Faktur", 91, HorizontalAlignment.Center);
            lsvLaporanPengeluaran.Columns.Add("Tanggal", 110, HorizontalAlignment.Center);
            lsvLaporanPengeluaran.Columns.Add("Kode Pengurus", 110, HorizontalAlignment.Center);
            lsvLaporanPengeluaran.Columns.Add("Total Keluar", 91, HorizontalAlignment.Center);
            lsvLaporanPengeluaran.Columns.Add("Keperluan", 91, HorizontalAlignment.Center);
            lsvLaporanPengeluaran.Columns.Add("No Rekening", 91, HorizontalAlignment.Center);

        }

        private void LoadDataPengeluaran()
        {
            // kosongkan listview
            lsvLaporanPengeluaran.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfPengeluaran = pengeluaranController.ReadAll();

            // ekstrak objek prs dari collection
            foreach (var plr in listOfPengeluaran)
            {
                var noUrut = lsvLaporanPengeluaran.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(plr.No_Faktur);
                item.SubItems.Add(plr.Tanggal);
                item.SubItems.Add(plr.Kode_pengurus);
                item.SubItems.Add(plr.Total_keluar);
                item.SubItems.Add(plr.Keperluan);
                item.SubItems.Add(plr.No_rekening);

                // tampilkan data prs ke listview
                lsvLaporanPengeluaran.Items.Add(item);
            }

            


        }
        private void OnCreateEventHandler(Pengeluaran plr)
        {
            // tambahkan objek prs yang baru ke dalam collection
            listOfPengeluaran.Add(plr);

            int noUrut = lsvLaporanPengeluaran.Items.Count + 1;

            // tampilkan data prs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(plr.No_Faktur);
            item.SubItems.Add(plr.Tanggal);
            item.SubItems.Add(plr.Kode_pengurus);
            item.SubItems.Add(plr.Keperluan);
            item.SubItems.Add(plr.No_rekening);

            lsvLaporanPengeluaran.Items.Add(item);
        }

        private void OnUpdateEventHandler(Pengeluaran plr)
        {
            // ambil index data prs yang edit
            int index = lsvLaporanPengeluaran.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = lsvLaporanPengeluaran.Items[index];
            itemRow.SubItems[1].Text = plr.No_Faktur;
            itemRow.SubItems[2].Text = plr.Tanggal;
            itemRow.SubItems[3].Text = plr.Kode_pengurus;
            itemRow.SubItems[4].Text = plr.Keperluan;
            itemRow.SubItems[5].Text = plr.No_rekening;
        }

        private void btnTambahPengeluaran_Click(object sender, EventArgs e)
        {
                // buat objek form entry data mahasiswa
                FrmEntryPengeluaran frmEntry = new FrmEntryPengeluaran("Entry Data Pengurus", pengeluaranController);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnCreate += OnCreateEventHandler;

                // tampilkan form entry mahasiswa
                frmEntry.ShowDialog();
        }

        private void btnPerbaikiPengeluaran_Click(object sender, EventArgs e)
        {
            if (lsvLaporanPengeluaran.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Pengeluaran plr = listOfPengeluaran[lsvLaporanPengeluaran.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FrmEntryPengeluaran frmEntry = new FrmEntryPengeluaran("Edit Data Pengurus", plr, pengeluaranController);

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

        private void btnHapusPengeluaran_Click(object sender, EventArgs e)
        {
            if (lsvLaporanPengeluaran.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data pengurus ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Pengeluaran plr = listOfPengeluaran[lsvLaporanPengeluaran.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = pengeluaranController.Delete(plr);
                    if (result > 0) LoadDataPengeluaran();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data pengurus belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCariLaporanPengeluaran_TextChanged(object sender, EventArgs e)
        {
            lsvLaporanPengeluaran.Items.Clear();

            listOfPengeluaran = pengeluaranController.ReadByNoFaktur(txtCariLaporanPengeluaran.Text);

            foreach (var klr in listOfPengeluaran)
            {
                var noUrut = lsvLaporanPengeluaran.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(klr.No_Faktur);
                item.SubItems.Add(klr.Tanggal);
                item.SubItems.Add(klr.Kode_pengurus);
                item.SubItems.Add(klr.Keperluan);
                item.SubItems.Add(klr.No_rekening);

                lsvLaporanPengeluaran.Items.Add(item);
            }
        }

        private void btnExportLaporanPengeluaran_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "No Faktur";
                    ws.Cells[1, 2] = "Tanggal";
                    ws.Cells[1, 3] = "Kode Pengurus";
                    ws.Cells[1, 4] = "Total Keluar";
                    ws.Cells[1, 5] = "Keperluan";
                    ws.Cells[1, 6] = "No Rekening";

                    int i = 2;
                    foreach (ListViewItem item in lsvLaporanPengeluaran.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
                        ws.Cells[i, 5] = item.SubItems[5].Text;
                        i++;
                    }
                    wb.SaveAs(sfd.FileName, XlFileFormat.xlWorkbookDefault, Type.Missing, Type.Missing, true, false, XlSaveAsAccessMode.xlNoChange, XlSaveConflictResolution.xlLocalSessionChanges, Type.Missing, Type.Missing);
                    app.Quit();
                    MessageBox.Show("Laporan telah berhasil di export", "Message", MessageBoxButtons.OK);
                }
            }
        }
    }
}
