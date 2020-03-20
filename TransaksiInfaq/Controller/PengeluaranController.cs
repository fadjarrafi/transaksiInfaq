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
    public class PengeluaranController
    {
        private PengeluaranRepository _repository;
        public int Create(Pengeluaran pengeluaran)
        {
            int result = 0;
            if (string.IsNullOrEmpty(pengeluaran.No_Faktur))
            {
                MessageBox.Show("No Faktur Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.Tanggal))
            {
                MessageBox.Show("Tanggal Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.Kode_pengurus))
            {
                MessageBox.Show("Kode Pengurus Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.Total_keluar))
            {
                MessageBox.Show("Total Keluar Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.Keperluan))
            {
                MessageBox.Show("Keperluan Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.No_rekening))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DbContext context = new DbContext())
            {
                _repository = new PengeluaranRepository(context);
                result = _repository.Create(pengeluaran);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Pengeluaran disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Pengeluaran gagal disimpan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Update(Pengeluaran pengeluaran)
        {
            int result = 0;
            if (string.IsNullOrEmpty(pengeluaran.No_Faktur))
            {
                MessageBox.Show("No Faktur Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.Tanggal))
            {
                MessageBox.Show("Tanggal Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.Kode_pengurus))
            {
                MessageBox.Show("Kode Pengurus Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.Total_keluar))
            {
                MessageBox.Show("Total Keluar Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.Keperluan))
            {
                MessageBox.Show("Keperluan Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.No_rekening))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PengeluaranRepository(context);
                result = _repository.Update(pengeluaran);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pengeluaran berhasil diupdate !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Pengeluaran gagal diupdate !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public int Delete(Pengeluaran pengeluaran)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pengeluaran.No_Faktur))
            {
                MessageBox.Show("No Faktur Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.Tanggal))
            {
                MessageBox.Show("Tanggal Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.Kode_pengurus))
            {
                MessageBox.Show("Kode Pengurus Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.Total_keluar))
            {
                MessageBox.Show("Total Keluar Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.Keperluan))
            {
                MessageBox.Show("Keperluan Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengeluaran.No_rekening))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PengeluaranRepository(context);
                result = _repository.Delete(pengeluaran);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pengeluaran berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Pengeluaran gagal dihapus !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public List<Pengeluaran> ReadAll()
        {
            List<Pengeluaran> list = new List<Pengeluaran>();

            using (DbContext context = new DbContext())
            {
                _repository = new PengeluaranRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public List<Pengeluaran> ReadByNoFaktur(string No_Faktur)
        {
            List<Pengeluaran> list = new List<Pengeluaran>();

            using (DbContext context = new DbContext())
            {
                _repository = new PengeluaranRepository(context);
                list = _repository.ReadByNoFaktur(No_Faktur);
            }

            return list;
        }
    }
}
