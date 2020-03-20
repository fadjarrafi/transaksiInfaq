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
    public partial class FrmEntryPemasukan : Form
    {
        public delegate void CreateUpdateEventHandler(Pemasukan pmk);

        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private PemasukanController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        //deklarasi field untuk menyimpan objek
        private Pemasukan pmk;

        public FrmEntryPemasukan()
        {
            InitializeComponent();
        }

        public FrmEntryPemasukan (string title, PemasukanController controller)
            :this()
        {
            this.Text = title;
            this.controller = controller;
        }

        public FrmEntryPemasukan (string title, Pemasukan obj, PemasukanController controller)
            :this()
        {
            this.Text = title;
            this.controller = controller;

            isNewData = false;
            pmk = obj;

            txtKodeMasukPemasukan.Text = pmk.Kode_masuk;
            dtpTanggalPemasukan.Text = pmk.Tanggal;
            txtKodePengurusPemasukan.Text = pmk.Kode_Pengurus;
            txtRekeningPemasukan.Text = pmk.No_rekening;
            txtTotalMasuk.Text = pmk.Total_masuk;
        }

        private void btnSimpanPemasukan_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) pmk = new Pemasukan();

            dtpTanggalPemasukan.Format = DateTimePickerFormat.Custom;
            dtpTanggalPemasukan.CustomFormat = "yyyy-MM-dd";

            pmk.Kode_masuk = txtKodeMasukPemasukan.Text;
            pmk.Tanggal = dtpTanggalPemasukan.Text;
            pmk.Kode_Pengurus = txtKodePengurusPemasukan.Text;
            pmk.No_rekening = txtRekeningPemasukan.Text;
            pmk.Total_masuk = txtTotalMasuk.Text;

            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(pmk);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(pmk); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtKodeMasukPemasukan.Clear();
                    txtKodePengurusPemasukan.Clear();
                    txtRekeningPemasukan.Clear();
                    txtTotalMasuk.Clear();

                    txtKodeMasukPemasukan.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(pmk);

                if (result > 0)
                {
                    OnUpdate(pmk); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnSelesaiEntryPemasukan_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
