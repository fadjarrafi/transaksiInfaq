using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using TransaksiInfaq.Model.Entity;
using TransaksiInfaq.Model.Context;

namespace TransaksiInfaq.Model.Repository
{
    public class PemasukanRepository
    {
        private OleDbConnection _conn;
        public PemasukanRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Pemasukan msk)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into Pemasukan (Kode_masuk, Tanggal, Kode_Pengurus, No_rekening, Total_masuk)
                   values (@Kode_masuk, @Tanggal, @Kode_Pengurus, @No_rekening, @Total_masuk)";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Kode_masuk", msk.Kode_masuk);
                cmd.Parameters.AddWithValue("@Tanggal", msk.Tanggal);
                cmd.Parameters.AddWithValue("@Kode_Pengurus", msk.Kode_Pengurus);
                cmd.Parameters.AddWithValue("@No_rekening", msk.No_rekening);
                cmd.Parameters.AddWithValue("@Total_masuk", msk.Total_masuk);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Pemasukan msk)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update Pemasukan set Tanggal=@Tanggal, Kode_Pengurus=@Kode_Pengurus, No_rekening=@No_rekening, Total_masuk=@Total_masuk where  Kode_masuk=@Kode_masuk";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Tanggal", msk.Tanggal);
                cmd.Parameters.AddWithValue("@Kode_Pengurus", msk.Kode_Pengurus);
                cmd.Parameters.AddWithValue("@No_rekening", msk.No_rekening);
                cmd.Parameters.AddWithValue("@Total_masuk", msk.Total_masuk);
                cmd.Parameters.AddWithValue("@Kode_masuk", msk.Kode_masuk);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Pemasukan msk)
        {
            int result = 0;

            // Deklarasi perintah SQL
            string sql = @"delete from Pemasukan where Kode_masuk = @Kode_masuk";

            // Membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Kode_masuk", msk.Kode_masuk);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete error: {0}", ex.Message);
                }
            }

            return result;
        }

        public List<Pemasukan> ReadAll()
        {
            List<Pemasukan> list = new List<Pemasukan>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select Kode_masuk, Tanggal, Kode_Pengurus, No_rekening 
                        from Pemasukan 
                        order by Tanggal";

                // membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pemasukan msk = new Pemasukan();
                            msk.Kode_masuk = dtr["Kode_masuk"].ToString();
                            msk.Tanggal = dtr["Tanggal"].ToString();
                            msk.Kode_Pengurus = dtr["Kode_Pengurus"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(msk);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll error: {0}", ex.Message);
            }

            return list;

        }
    }
}
