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
    public class Detail_KeluarController
    {
        private Detail_KeluarRepository _repository;
        public int Create(Detail_Keluar detail_keluar)
        {
            int result = 0;
            if (string.IsNullOrEmpty(detail_keluar.No_Faktur))
            {
                MessageBox.Show("No Faktur Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(detail_keluar.Kode_Barang))
            {
                MessageBox.Show("Kode Barang Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            
            if (string.IsNullOrEmpty(detail_keluar.Jumlah))
            {
                MessageBox.Show("Jumlah Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
           


            using (DbContext context = new DbContext())
            {
                _repository = new Detail_KeluarRepository(context);
                result = _repository.Create(detail_keluar);
            }
            if (result > 0)
            {
                MessageBox.Show("Data Detail Keluar disimpan !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Detail Keluar gagal disimpan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return result;
        }
        public int Update(Detail_Keluar detail_keluar)
        {
            int result = 0;
            if (string.IsNullOrEmpty(detail_keluar.No_Faktur))
            {
                MessageBox.Show("No Faktur Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(detail_keluar.Kode_Barang))
            {
                MessageBox.Show("Kode Barang Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(detail_keluar.Jumlah))
            {
                MessageBox.Show("Jumlah Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            using (DbContext context = new DbContext())
            {
                _repository = new Detail_KeluarRepository(context);
                result = _repository.Update(detail_keluar);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Detail Keluar berhasil diupdate !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Detail Keluar gagal diupdate !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public int Delete(Detail_Keluar detail_keluar)
        {
            int result = 0;
            if (string.IsNullOrEmpty(detail_keluar.No_Faktur))
            {
                MessageBox.Show("No Faktur Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }
            if (string.IsNullOrEmpty(detail_keluar.Kode_Barang))
            {
                MessageBox.Show("Kode Barang Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }

            if (string.IsNullOrEmpty(detail_keluar.Jumlah))
            {
                MessageBox.Show("Jumlah Harus Diisi !", "Peringatan ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return 0;
            }


            using (DbContext context = new DbContext())
            {
                _repository = new Detail_KeluarRepository(context);
                result = _repository.Delete(detail_keluar);
            }

            if (result > 0)
            {
                MessageBox.Show("Data Detail Keluar berhasil dihapus !", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Detail Keluar gagal dihapus !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            return result;
        }
        public List<Detail_Keluar> ReadAll()
        {
            List<Detail_Keluar> list = new List<Detail_Keluar>();

            using (DbContext context = new DbContext())
            {
                _repository = new Detail_KeluarRepository(context);
                list = _repository.ReadAll();
            }

            return list;
        }

        public List<Detail_Keluar> ReadByNoFaktur(string No_Faktur)
        {
            List<Detail_Keluar> list = new List<Detail_Keluar>();

            using (DbContext context = new DbContext())
            {
                _repository = new Detail_KeluarRepository(context);
                list = _repository.ReadByNoFaktur(No_Faktur);
            }

            return list;
        }
    }
}
