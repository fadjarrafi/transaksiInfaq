using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransaksiInfaq.Controller;
using TransaksiInfaq.Model.Entity;

namespace TransaksiInfaq.View
{
    public partial class FrmEntryDetailKeluar : Form
    {
        public delegate void CreateUpdateEventHandler(Detail_Keluar klr);

        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private Detail_KeluarController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        //deklarasi field untuk menyimpan objek
        private Detail_Keluar klr;
        public FrmEntryDetailKeluar()
        {
            InitializeComponent();
        }

        public FrmEntryDetailKeluar(string title, Detail_KeluarController controller)
          : this()
        {
            this.Text = title;
            this.controller = controller;
        }
     
        public FrmEntryDetailKeluar(string title, Detail_Keluar obj, Detail_KeluarController controller)
          : this()
        {
            this.Text = title;
            this.controller = controller;

            isNewData = false;
            klr = obj;

            txtNoFaktur.Text = klr.No_Faktur;
            txtKodeBarang.Text = klr.Kode_Barang;
            txtJumlah.Text = klr.Jumlah;
        }

        private void btnSimpanDetailKeluar_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) klr = new Detail_Keluar();

            klr.No_Faktur = txtNoFaktur.Text;
            klr.Kode_Barang = txtKodeBarang.Text;
            klr.Jumlah = txtJumlah.Text;


            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(klr);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(klr); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtNoFaktur.Clear();
                    txtKodeBarang.Clear();
                    txtJumlah.Clear();


                    txtKodeBarang.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(klr);

                if (result > 0)
                {
                    OnUpdate(klr); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnSelesaiDetailKeluar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
