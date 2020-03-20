using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
using TransaksiInfaq.Model.Entity;
using TransaksiInfaq.Model.Context;

namespace TransaksiInfaq.Model.Repository
{
    public class PemasukanRepository
    {
        private MySqlConnection _conn;
        public PemasukanRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Pemasukan msk)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into pemasukan values (@Kode_masuk, @Tanggal, @Kode_Pengurus, @No_rekening, @Total_masuk)";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
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
            string sql = @"update pemasukan set Tanggal =@Tanggal, Kode_Pengurus =@Kode_Pengurus, No_rekening =@No_rekening, Total_masuk =@Total_masuk where  Kode_masuk =@Kode_masuk";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
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
            string sql = @"delete from pemasukan where Kode_masuk = @Kode_masuk";

            // Membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
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
                string sql = @"select * from pemasukan";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pemasukan msk = new Pemasukan();
                            msk.Kode_masuk = dtr["Kode_masuk"].ToString();
                            msk.Tanggal = dtr["Tanggal"].ToString();
                            msk.Kode_Pengurus = dtr["Kode_Pengurus"].ToString();
                            msk.No_rekening = dtr["No_rekening"].ToString();
                            msk.Total_masuk = dtr["Total_masuk"].ToString();

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

        public List<Pemasukan> ReadByKodeMasuk(string Kode_masuk)
        {
            List<Pemasukan> list = new List<Pemasukan>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from pemasukan where Kode_masuk like @Kode_masuk order by Kode_masuk";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Kode_masuk", "%" + Kode_masuk + "%");
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pemasukan msk = new Pemasukan();
                            msk.Kode_masuk = dtr["Kode_masuk"].ToString();
                            msk.Tanggal = dtr["Tanggal"].ToString();
                            msk.Kode_Pengurus = dtr["Kode_Pengurus"].ToString();
                            msk.No_rekening = dtr["No_rekening"].ToString();
                            msk.Total_masuk = dtr["Total_masuk"].ToString();

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
