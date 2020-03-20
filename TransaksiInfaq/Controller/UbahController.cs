using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using TransaksiInfaq.Model.Entity;
using TransaksiInfaq.Model.Repository;
using TransaksiInfaq.Model.Context; 

namespace TransaksiInfaq.Controller
{
    public class UbahController
    {
        private UbahRepository _repository;

        public bool IsValidUser(string Kode_Pengurus)
        {
            // cek Kode_Pengurus yang diinputkan tidak boleh kosong
            if (string.IsNullOrEmpty(Kode_Pengurus))
            {
                MessageBox.Show("User name harus diisi !!!", "Peringatan",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            bool isValidUser = false;

            // membuat objek context menggunakan blok using
            using (DbContext context = new DbContext())
            {
                // membuat objek class repository
                _repository = new UbahRepository(context);

                // panggil method Create class repository untuk menambahkan data
                isValidUser = _repository.IsValidUser(Kode_Pengurus);
            }

            if (!isValidUser)
            {
                MessageBox.Show("Kode Pengurus Tidak Ditemukan salah !!!", "Peringatan",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        public int Update(Pengurus pengurus)
        {
            int result = 0;

            
            using (DbContext context = new DbContext())
            {
                _repository = new UbahRepository(context);
                result = _repository.Update(pengurus);
            }

            if (result > 0)
            {
                MessageBox.Show("Password berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password gagal diuubah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
    }
}
