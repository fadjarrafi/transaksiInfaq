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
    public partial class FrmEntryDataPengurus : Form
    {
        public delegate void CreateUpdateEventHandler(Pengurus prs);

        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private PengurusController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        //deklarasi field untuk menyimpan objek
        private Pengurus prs;
        public FrmEntryDataPengurus()
        {
            InitializeComponent();
        }

        // constructor untuk inisialisasi data ketika entri data baru
        public FrmEntryDataPengurus(string title, PengurusController controller)
            : this()
        {
            this.Text = title;
            this.controller = controller;
        }

        // constructor untuk inisialisasi data ketika mengedit data
        public FrmEntryDataPengurus(string title, Pengurus obj, PengurusController controller)
            : this()
        {
            // ganti text/judul form
            this.Text = title;
            this.controller = controller;

            isNewData = false; //set status edit data
            prs = obj; // set objek prs yang akan diedit

            //untuk edit data, tampilkan data lama
            txtKodePengurusInsert.Text = prs.Kode_Pengurus;
            txtNamaInsert.Text = prs.Nama;
            rtxtAlamatInsert.Text = prs.Alamat;
            txtNoTelpInsert.Text = prs.No_Telepon;
            txtUsernameInsert.Text = prs.Username;
            txtPasswordInsert.Text = prs.Password;

        }

        private void btnSimpanDataPengurus_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) prs = new Pengurus();

            // set nilai property objek mahasiswa yg diambil dari TextBox
            prs.Kode_Pengurus = txtKodePengurusInsert.Text;
            prs.Nama = txtNamaInsert.Text;
            prs.Alamat = rtxtAlamatInsert.Text;
            prs.No_Telepon = txtNoTelpInsert.Text;
            prs.Username = txtUsernameInsert.Text;
            prs.Password = txtPasswordInsert.Text;

            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(prs);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(prs); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtKodePengurusInsert.Clear();
                    txtNamaInsert.Clear();
                    rtxtAlamatInsert.Clear();
                    txtNoTelpInsert.Clear();
                    txtUsernameInsert.Clear();
                    txtPasswordInsert.Clear();

                    txtKodePengurusInsert.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(prs);

                if (result > 0)
                {
                    OnUpdate(prs); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
