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
    public partial class FrmEntryPengeluaran : Form
    {
        public delegate void CreateUpdateEventHandler(Pengeluaran plr);

        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private PengeluaranController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        //deklarasi field untuk menyimpan objek
        private Pengeluaran plr;
        public FrmEntryPengeluaran()
        {
            InitializeComponent();
        }

        public FrmEntryPengeluaran(string title, PengeluaranController controller)
           : this()
        {
            this.Text = title;
            this.controller = controller;
        }

        public FrmEntryPengeluaran(string title, Pengeluaran obj, PengeluaranController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; //set status edit data
            plr = obj; // set objek prs yang akan diedit

            //untuk edit data, tampilkan data lama
            txtFakturPengeluaran.Text = plr.No_Faktur;
            dtpTanggalPengeluaran.Text = plr.Tanggal;
            txtKodePengurusPengeluaran.Text = plr.Kode_pengurus;
            txtTotalPengeluaran.Text = plr.Total_keluar;
            txtTotalPengeluaran.Text = plr.Keperluan;
            txtRekeningPengeluaran.Text = plr.No_rekening;
        }

        private void btnSelesaiPengeluaran_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpanPengeluaran_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) plr = new Pengeluaran();

            dtpTanggalPengeluaran.Format = DateTimePickerFormat.Custom;
            dtpTanggalPengeluaran.CustomFormat = "yyyy-MM-dd";

            // set nilai property objek mahasiswa yg diambil dari TextBox
            plr.No_Faktur = txtFakturPengeluaran.Text;
            plr.Tanggal = dtpTanggalPengeluaran.Text;
            plr.Kode_pengurus = txtKodePengurusPengeluaran.Text;
            plr.Total_keluar = txtTotalPengeluaran.Text;
            plr.Keperluan = txtTotalPengeluaran.Text;
            plr.No_rekening = txtRekeningPengeluaran.Text;
 

            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(plr);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(plr); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtFakturPengeluaran.Clear();
                    txtKodePengurusPengeluaran.Clear();
                    txtTotalPengeluaran.Clear();
                    txtRekeningPengeluaran.Clear();

                    txtFakturPengeluaran.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(plr);

                if (result > 0)
                {
                    OnUpdate(plr); // panggil event OnUpdate
                    this.Close();
                }
            }
        }
    }
}
