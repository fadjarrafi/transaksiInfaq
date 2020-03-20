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
    public class BarangController
    {
        private BarangRepository _repository;
        public int Create(Barang barang)
        {
            int result = 0;
            if (string.IsNullOrEmpty(barang.Kode_Barang))
            {
                MessageBox.Show("Kode Barang Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(barang.Nama_Barang))
            {
                MessageBox.Show("Nama Barang Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(barang.Harga))
            {
                MessageBox.Show("Harga Barang Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DbContext context = new DbContext())
            {
                _repository = new BarangRepository(context);
                result = _repository.Create(barang);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Barang disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Barang gagal disimpan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Update(Barang barang)
        {
            int result = 0;

            if (string.IsNullOrEmpty(barang.Kode_Barang))
            {
                MessageBox.Show("Kode Harus harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(barang.Nama_Barang))
            {
                MessageBox.Show("Nama Barang Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(barang.Harga))
            {
                MessageBox.Show("Harga Barang Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DbContext context = new DbContext())
            {
                _repository = new BarangRepository(context);
                result = _repository.Update(barang);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Barang berhasil diupdate !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Barang gagal diupdate !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public int Delete(Barang barang)
        {
            int result = 0;

            if (string.IsNullOrEmpty(barang.Kode_Barang))
            {
                MessageBox.Show("Kode Barang harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(barang.Nama_Barang))
            {
                MessageBox.Show("Nama Barang Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(barang.Harga))
            {
                MessageBox.Show("Harga Barang Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new BarangRepository(context);
                result = _repository.Delete(barang);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Barang berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Barang gagal dihapus !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public List<Barang> ReadAll()
        {
            List<Barang> list = new List<Barang>();

            using (DbContext context = new DbContext())
            {
                _repository = new BarangRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }
        public List<Barang> ReadByNama(string Nama)
        {
            List<Barang> list = new List<Barang>();

            using (DbContext context = new DbContext())
            {
                _repository = new BarangRepository(context);
                list = _repository.ReadByNama(Nama);
            }

            return list;
        }
    }
}
