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
    public class TabunganController
    {
        private TabunganRepository _repository;
        public int Create(Tabungan tabungan)
        {
            int result = 0;
            if (string.IsNullOrEmpty(tabungan.No_rekening))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tabungan.Bank))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tabungan.Saldo))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
          

            using (DbContext context = new DbContext())
            {
                _repository = new TabunganRepository(context);
                result = _repository.Create(tabungan);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Tabungan disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Tabungan disimpan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Update(Tabungan tabungan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(tabungan.No_rekening))
            {
                MessageBox.Show("No Rekening harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tabungan.Bank))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tabungan.Saldo))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DbContext context = new DbContext())
            {
                _repository = new TabunganRepository(context);
                result = _repository.Update(tabungan);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Tabungan berhasil diupdate !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Tabungan gagal diupdate !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public int Delete(Tabungan tabungan)
        {
            int result = 0;

            if (string.IsNullOrEmpty(tabungan.No_rekening))
            {
                MessageBox.Show("No Rekening harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tabungan.Bank))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(tabungan.Saldo))
            {
                MessageBox.Show("No Rekening Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new TabunganRepository(context);
                result = _repository.Delete(tabungan);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Tabungan berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Tabungan gagal dihapus !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public List<Tabungan> ReadAll()
        {
            List<Tabungan> list = new List<Tabungan>();

            using (DbContext context = new DbContext())
            {
                _repository = new TabunganRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public List<Tabungan> ReadByNoRekening(string No_rekening)
        {
            List<Tabungan> list = new List<Tabungan>();

            using (DbContext context = new DbContext())
            {
                _repository = new TabunganRepository(context);
                list = _repository.ReadByNoRekening(No_rekening);
            }

            return list;
        }

    }
}
