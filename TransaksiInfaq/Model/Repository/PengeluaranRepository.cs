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
    public class PengeluaranRepository
    {
        private MySqlConnection _conn;
        public PengeluaranRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Pengeluaran klr)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into pengeluaran values (@No_Faktur, @Tanggal, @Kode_Pengurus, @Total_keluar, @Keperluan, @No_rekening)";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@No_Faktur", klr.No_Faktur);
                cmd.Parameters.AddWithValue("@Tanggal", klr.Tanggal);
                cmd.Parameters.AddWithValue("@Kode_pengurus", klr.Kode_pengurus);
                cmd.Parameters.AddWithValue("@Total_keluar", klr.Total_keluar);
                cmd.Parameters.AddWithValue("@Keperluan", klr.Keperluan);
                cmd.Parameters.AddWithValue("@No_rekening", klr.No_rekening);

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

        public int Update(Pengeluaran klr)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update pengeluaran set No_Faktur=@No_Faktur, Tanggal=@Tanggal, Kode_pengurus=@Kode_Pengurus, Total_keluar=@Total_keluar, keperluan=@Keperluan, No_rekening=@No_rekening";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@No_Faktur", klr.No_Faktur);
                cmd.Parameters.AddWithValue("@Tanggal", klr.Tanggal);
                cmd.Parameters.AddWithValue("@Kode_pengurus", klr.Kode_pengurus);
                cmd.Parameters.AddWithValue("@Total_keluar", klr.Total_keluar);
                cmd.Parameters.AddWithValue("@Keperluan", klr.Keperluan);
                cmd.Parameters.AddWithValue("@No_rekening", klr.No_rekening);

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

        public int Delete(Pengeluaran klr)
        {
            int result = 0;

            // Deklarasi perintah SQL
            string sql = @"delete from pengeluaran where No_Faktur = @No_Faktur";

            // Membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@No_Faktur", klr.No_Faktur);

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

        public List<Pengeluaran> ReadAll()
        {
            List<Pengeluaran> list = new List<Pengeluaran>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from pengeluaran";

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
                            Pengeluaran klr = new Pengeluaran();
                            klr.No_Faktur = dtr["No_Faktur"].ToString();
                            klr.Tanggal = dtr["Tanggal"].ToString();
                            klr.Kode_pengurus = dtr["Kode_pengurus"].ToString();
                            klr.Total_keluar = dtr["Total_keluar"].ToString();
                            klr.Keperluan = dtr["Keperluan"].ToString();
                            klr.No_rekening = dtr["No_rekening"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(klr);
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

        public List<Pengeluaran> ReadByNoFaktur(string No_Faktur)
        {
            List<Pengeluaran> list = new List<Pengeluaran>();
            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from Pengeluaran where No_Faktur like @ No_Faktur order by No_Faktur";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@No_Faktur", "%" + No_Faktur + "%");
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Pengeluaran klr = new Pengeluaran();
                            klr.No_Faktur = dtr["No_Faktur"].ToString();
                            klr.Tanggal = dtr["Tanggal"].ToString();
                            klr.Kode_pengurus = dtr["Kode_pengurus"].ToString();
                            klr.Total_keluar = dtr["Total_keluar"].ToString();
                            klr.Keperluan = dtr["Keperluan"].ToString();
                            klr.No_rekening = dtr["No_rekening"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(klr);
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
