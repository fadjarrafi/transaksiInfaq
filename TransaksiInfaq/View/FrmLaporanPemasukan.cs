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
    public partial class FrmLaporanPemasukan : Form
    {
        private List<Pemasukan> listOfPemasukan = new List<Pemasukan>();

        private PemasukanController pemasukanController;

        public FrmLaporanPemasukan()
        {
            InitializeComponent();
            pemasukanController = new PemasukanController();
            InisialisasiListViewPemasukan();
            LoadDataPemasukan();
        }

        private void InisialisasiListViewPemasukan()
        {
            lsvLaporanPemasukan.View = System.Windows.Forms.View.Details;
            lsvLaporanPemasukan.FullRowSelect = true;
            lsvLaporanPemasukan.GridLines = true;

            lsvLaporanPemasukan.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lsvLaporanPemasukan.Columns.Add("Kode Masuk", 91, HorizontalAlignment.Center);
            lsvLaporanPemasukan.Columns.Add("Tanggal", 110, HorizontalAlignment.Center);
            lsvLaporanPemasukan.Columns.Add("Kode Pengurus", 110, HorizontalAlignment.Center);
            lsvLaporanPemasukan.Columns.Add("No Rekening", 91, HorizontalAlignment.Center);
            lsvLaporanPemasukan.Columns.Add("Total Masuk", 91, HorizontalAlignment.Center);

        }

        private void LoadDataPemasukan()
        {
            // kosongkan listview
            lsvLaporanPemasukan.Items.Clear();

            // panggil method ReadAll dan tampung datanya ke dalam collection
            listOfPemasukan = pemasukanController.ReadAll();

            // ekstrak objek prs dari collection
            foreach (var pmk in listOfPemasukan)
            {
                var noUrut = lsvLaporanPemasukan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(pmk.Kode_masuk);
                item.SubItems.Add(pmk.Tanggal);
                item.SubItems.Add(pmk.Kode_Pengurus);
                item.SubItems.Add(pmk.No_rekening);
                item.SubItems.Add(pmk.Total_masuk);

                // tampilkan data prs ke listview
                lsvLaporanPemasukan.Items.Add(item);
            }

        }

        private void OnCreateEventHandler(Pemasukan pmk)
        {
            // tambahkan objek prs yang baru ke dalam collection
            listOfPemasukan.Add(pmk);

            int noUrut = lsvLaporanPemasukan.Items.Count + 1;

            // tampilkan data prs yg baru ke list view
            ListViewItem item = new ListViewItem(noUrut.ToString());
            item.SubItems.Add(pmk.Kode_masuk);
            item.SubItems.Add(pmk.Tanggal);
            item.SubItems.Add(pmk.Kode_Pengurus);
            item.SubItems.Add(pmk.No_rekening);
            item.SubItems.Add(pmk.Total_masuk);

            lsvLaporanPemasukan.Items.Add(item);
        }

        // method event handler untuk merespon event OnUpdate,
        private void OnUpdateEventHandler(Pemasukan pmk)
        {
            // ambil index data prs yang edit
            int index = lsvLaporanPemasukan.SelectedIndices[0];

            // update informasi mhs di listview
            ListViewItem itemRow = lsvLaporanPemasukan.Items[index];
            itemRow.SubItems[1].Text = pmk.Kode_masuk;
            itemRow.SubItems[2].Text = pmk.Tanggal;
            itemRow.SubItems[3].Text = pmk.Kode_Pengurus;
            itemRow.SubItems[4].Text = pmk.No_rekening;
            itemRow.SubItems[5].Text = pmk.Total_masuk;
        }

        private void btnTambahPemasukan_Click(object sender, EventArgs e)
        {
                // buat objek form entry data mahasiswa
                FrmEntryPemasukan frmEntry = new FrmEntryPemasukan ("Entry Data Pengurus", pemasukanController);

                // mendaftarkan method event handler untuk merespon event OnUpdate
                frmEntry.OnCreate += OnCreateEventHandler;

                // tampilkan form entry mahasiswa
                frmEntry.ShowDialog();
            
        }

        private void btnPerbaikiPemasukan_Click(object sender, EventArgs e)
        {
            if (lsvLaporanPemasukan.SelectedItems.Count > 0)
            {
                // ambil objek mhs yang mau diedit dari collection
                Pemasukan pmk = listOfPemasukan[lsvLaporanPemasukan.SelectedIndices[0]];

                // buat objek form entry data mahasiswa
                FrmEntryPemasukan frmEntry = new FrmEntryPemasukan("Edit Data Pengurus", pmk, pemasukanController);

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

        private void btnHapusPemasukan_Click(object sender, EventArgs e)
        {
            if (lsvLaporanPemasukan.SelectedItems.Count > 0)
            {
                var konfirmasi = MessageBox.Show("Apakah data pengurus ingin dihapus?", "Konfirmasi",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (konfirmasi == DialogResult.Yes)
                {
                    // ambil objek mhs yang mau dihapus dari collection
                    Pemasukan pmk = listOfPemasukan[lsvLaporanPemasukan.SelectedIndices[0]];

                    // panggil operasi CRUD
                    var result = pemasukanController.Delete(pmk);
                    if (result > 0) LoadDataPemasukan();
                }
            }
            else // data belum dipilih
            {
                MessageBox.Show("Data pengurus belum dipilih !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtCariPemasukan_TextChanged(object sender, EventArgs e)
        {
            lsvLaporanPemasukan.Items.Clear();

            listOfPemasukan = pemasukanController.ReadByKodeMasuk(txtCariPemasukan.Text);

            foreach (var msk in listOfPemasukan)
            {
                var noUrut = lsvLaporanPemasukan.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(msk.Kode_masuk);
                item.SubItems.Add(msk.Tanggal);
                item.SubItems.Add(msk.Kode_Pengurus);
                item.SubItems.Add(msk.No_rekening);
                item.SubItems.Add(msk.Total_masuk);

                lsvLaporanPemasukan.Items.Add(item);
            }
        }

        private void btnExportLaporanPemasukan_Click(object sender, EventArgs e)
        {
            using(SaveFileDialog sfd = new SaveFileDialog() {Filter= "Excel Workbook|*.xls", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    ws.Cells[1, 1] = "Kode Masuk";
                    ws.Cells[1, 2] = "Tanggal";
                    ws.Cells[1, 3] = "Kode Pengurus";
                    ws.Cells[1, 4] = "No Rekening";
                    ws.Cells[1, 5] = "Total Masuk";

                    int i = 2;
                    foreach(ListViewItem item in lsvLaporanPemasukan.Items)
                    {
                        ws.Cells[i, 1] = item.SubItems[0].Text;
                        ws.Cells[i, 2] = item.SubItems[1].Text;
                        ws.Cells[i, 3] = item.SubItems[2].Text;
                        ws.Cells[i, 4] = item.SubItems[3].Text;
                        ws.Cells[i, 5] = item.SubItems[4].Text;
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
