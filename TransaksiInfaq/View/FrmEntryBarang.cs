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
    public partial class FrmEntryBarang : Form
    {
        public delegate void CreateUpdateEventHandler(Barang brg);

        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private BarangController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        //deklarasi field untuk menyimpan objek
        private Barang brg;
        public FrmEntryBarang()
        {

            InitializeComponent();
        }

        public FrmEntryBarang(string title, BarangController controller)
           : this()
        {
            this.Text = title;
            this.controller = controller;
        }

        public FrmEntryBarang(string title, Barang obj, BarangController controller)
           : this()
        {
            this.Text = title;
            this.controller = controller;

            isNewData = false;
            brg = obj;

            txtKodeBarang.Text = brg.Kode_Barang;
            txtNamaBarang.Text = brg.Nama_Barang;
            txtHargaBarang.Text = brg.Harga;
        }

        private void btnSimpanBarang_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) brg = new Barang();

            brg.Kode_Barang = txtKodeBarang.Text;
            brg.Nama_Barang = txtNamaBarang.Text;
            brg.Harga = txtHargaBarang.Text;
           

            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(brg);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(brg); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtKodeBarang.Clear();
                    txtNamaBarang.Clear();
                    txtHargaBarang.Clear();
                 

                    txtKodeBarang.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(brg);

                if (result > 0)
                {
                    OnUpdate(brg); // panggil event OnUpdate
                    this.Close();
                }
            }
        }

        private void btnSelesaiBarang_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
