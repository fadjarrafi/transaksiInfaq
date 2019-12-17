using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using TransaksiInfaq.Model.Entity;
using TransaksiInfaq.Model.Context;
using TransaksiInfaq.Model.Repository;

namespace TransaksiInfaq.Controller
{
    public class PengurusController
    {
        private PengurusRepository _repository;
        public int Create(Pengurus pengurus)
        {
            int result = 0;
            if (string.IsNullOrEmpty(pengurus.Kode_Pengurus))
            {
                MessageBox.Show("Kode Pengurus Harus Diiisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pengurus.Nama))
            {
                MessageBox.Show("Nama harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengurus.No_Telepon))
            {
                MessageBox.Show("No Telepon harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengurus.Username))
            {
                MessageBox.Show("Username harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengurus.Password))
            {
                MessageBox.Show("Password harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            using (DbContext context = new DbContext())
            {
                _repository = new PengurusRepository(context);
                result = _repository.Create(pengurus);
            }
            if (result > 0)
            {
                MessageBox.Show("Data siswa Pengurus disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Pengurus gagal disimpan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Update(Pengurus pengurus)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pengurus.Kode_Pengurus))
            {
                MessageBox.Show("Kode Pengurus harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(pengurus.Nama))
            {
                MessageBox.Show("Nama harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengurus.No_Telepon))
            {
                MessageBox.Show("No Telepon harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengurus.Username))
            {
                MessageBox.Show("Username harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(pengurus.Password))
            {
                MessageBox.Show("Password harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DbContext context = new DbContext())
            {
                _repository = new PengurusRepository(context);
                result = _repository.Update(pengurus);
            }

            if (result > 0)
            {
                MessageBox.Show("Data pengurus berhasil diupdate !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data pengurus gagal diupdate !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public int Delete(Pengurus pengurus)
        {
            int result = 0;

            if (string.IsNullOrEmpty(pengurus.Kode_Pengurus))
            {
                MessageBox.Show("Kode Pengurus harus diisi !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new PengurusRepository(context);
                result = _repository.Delete(pengurus);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Pengurus berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Pengurus gagal dihapus !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }

        public List<Pengurus> ReadByNama(string nama)
        {
            List<Pengurus> list = new List<Pengurus>();

            using (DbContext context = new DbContext())
            {
                _repository = new PengurusRepository(context);
                list = _repository.ReadByNama(nama);
            }

            return list;
        }

        /**public List<Pengurus> ReadAll()
        {
            List<Pengurus> list = new List<Pengurus>();

            using (DbContext context = new DbContext())
            {
                _repository = new PengurusRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }**/

        public Pengurus ReadByKode_Pengurus(string Kode_Pengurus)
        {
            Pengurus pengurus = new Pengurus();
            using (DbContext context = new DbContext())
            {
                _repository = new PengurusRepository(context);
                pengurus = _repository.ReadByKode_Pengurus(Kode_Pengurus);
            }
            return pengurus;
        }

    }
}
