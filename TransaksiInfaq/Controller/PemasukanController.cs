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
    public class PemasukanController
    {
        private PemasukanRepository _repository;
        public int Create(Pemasukan pemasukan)
        {
            int result = 0;
            if (string.IsNullOrEmpty(pemasukan.Kode_masuk))
            {
                MessageBox.Show("Kode Pemasukan Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pemasukan.Tanggal))
            {
                MessageBox.Show("Tanggal Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pemasukan.Kode_Pengurus))
            {
                MessageBox.Show("Kode Pengurus Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pemasukan.No_rekening))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pemasukan.Total_masuk))
            {
                MessageBox.Show("Total Masuk Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DbContext context = new DbContext())
            {
                _repository = new PemasukanRepository(context);
                result = _repository.Create(pemasukan);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Pemasukan Pengurus disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Pemasukan gagal disimpan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Update(Pemasukan pemasukan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pemasukan.Kode_masuk))
            {
                MessageBox.Show("Kode Masuk harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pemasukan.Tanggal))
            {
                MessageBox.Show("Tanggal Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pemasukan.Kode_Pengurus))
            {
                MessageBox.Show("Kode Pengurus Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pemasukan.No_rekening))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pemasukan.Total_masuk))
            {
                MessageBox.Show("Total Masuk Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DbContext context = new DbContext())
            {
                _repository = new PemasukanRepository(context);
                result = _repository.Update(pemasukan);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pemasukan berhasil diupdate !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data pemasukan gagal diupdate !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public int Delete(Pemasukan pemasukan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pemasukan.Kode_masuk))
            {
                MessageBox.Show("Kode Pemasukan harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pemasukan.Tanggal))
            {
                MessageBox.Show("Tanggal Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pemasukan.Kode_Pengurus))
            {
                MessageBox.Show("Kode Pengurus Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pemasukan.No_rekening))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pemasukan.Total_masuk))
            {
                MessageBox.Show("Total Masuk Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PemasukanRepository(context);
                result = _repository.Delete(pemasukan);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pemasukan berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Pemasukan gagal dihapus !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public List<Pemasukan> ReadAll()
        {
            List<Pemasukan> list = new List<Pemasukan>();

            using (DbContext context = new DbContext())
            {
                _repository = new PemasukanRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public List<Pemasukan> ReadByKodeMasuk(string Kode_masuk)
        {
            List<Pemasukan> list = new List<Pemasukan>();

            using (DbContext context = new DbContext())
            {
                _repository = new PemasukanRepository(context);
                list = _repository.ReadByKodeMasuk(Kode_masuk);
            }

            return list;
        }

    }
}
