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
    public partial class FrmEntryTabungan : Form
    {
        public delegate void CreateUpdateEventHandler(Tabungan tbg);

        public event CreateUpdateEventHandler OnCreate;

        // deklarasi event ketika terjadi proses update data
        public event CreateUpdateEventHandler OnUpdate;

        // deklarasi objek controller
        private TabunganController controller;

        // deklarasi field untuk menyimpan status entry data (input baru atau update)
        private bool isNewData = true;

        //deklarasi field untuk menyimpan objek
        private Tabungan tbg;
        public FrmEntryTabungan()
        {
            InitializeComponent();
        }

        public FrmEntryTabungan(string title, TabunganController controller)
            :this()
        {
            this.Text = title;
            this.controller = controller;
        }

        public FrmEntryTabungan(string title, Tabungan obj, TabunganController controller)
           : this()
        {
            this.Text = title;
            this.controller = controller;

            isNewData = false;
            tbg = obj;

            txtNoRekeningTabungan.Text = tbg.No_rekening;
            txtBankPemasukan.Text = tbg.Bank;
            txtSaldoPemasukan.Text = tbg.Saldo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // jika data baru, inisialisasi objek mahasiswa
            if (isNewData) tbg = new Tabungan();

            tbg.No_rekening = txtNoRekeningTabungan.Text;
            tbg.Bank = txtBankPemasukan.Text;
            tbg.Saldo = txtSaldoPemasukan.Text;

            int result = 0;

            if (isNewData) // tambah data baru, panggil method Create
            {
                // panggil operasi CRUD
                result = controller.Create(tbg);

                if (result > 0) // tambah data berhasil
                {
                    OnCreate(tbg); // panggil event OnCreate

                    // reset form input, utk persiapan input data berikutnya
                    txtNoRekeningTabungan.Clear();
                    txtBankPemasukan.Clear();
                    txtSaldoPemasukan.Clear();

                    txtNoRekeningTabungan.Focus();
                }
            }
            else // edit data, panggil method Update
            {
                // panggil operasi CRUD
                result = controller.Update(tbg);

                if (result > 0)
                {
                    OnUpdate(tbg); // panggil event OnUpdate
                    this.Close();
                }
            }
        }
    }
}
