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
    public class Detail_KeluarRepository
    {
        private MySqlConnection _conn;

        public Detail_KeluarRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Detail_Keluar klr)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into detail_keluar (No_Faktur, Kode_Barang, Jumlah)
                   values (@No_Faktur, @Kode_Barang, @Jumlah)";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@No_Faktur", klr.No_Faktur);
                cmd.Parameters.AddWithValue("@Kode_Barang", klr.Kode_Barang);
                cmd.Parameters.AddWithValue("@Jumlah", klr.Jumlah);

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

        public int Update(Detail_Keluar klr)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update detail_keluar set  Kode_Barang=@Kode_Barang, Jumlah=@Jumlah where No_Faktur=@No_Faktur";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@No_Faktur", klr.No_Faktur);
                cmd.Parameters.AddWithValue("@Kode_Barang", klr.Kode_Barang);
                cmd.Parameters.AddWithValue("@Jumlah", klr.Jumlah);

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

        public int Delete(Detail_Keluar klr)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from detail_keluar where No_Faktur = @No_Faktur";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@No_Faktur", klr.No_Faktur);;

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

        public List<Detail_Keluar> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Detail_Keluar> list = new List<Detail_Keluar>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select No_Faktur, Kode_Barang, Jumlah 
                        from detail_keluar";

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
                            Detail_Keluar klr = new Detail_Keluar();
                            klr.No_Faktur = dtr["No_Faktur"].ToString();
                            klr.Kode_Barang = dtr["Kode_Barang"].ToString();
                            klr.Jumlah = dtr["Jumlah"].ToString();

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

        public List<Detail_Keluar> ReadByNoFaktur(string No_Faktur)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Detail_Keluar> list = new List<Detail_Keluar>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from detail_keluar where No_Faktur like @No_Faktur order by No_Faktur";

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
                            Detail_Keluar klr = new Detail_Keluar();
                            klr.No_Faktur = dtr["No_Faktur"].ToString();
                            klr.Kode_Barang = dtr["Kode_Barang"].ToString();
                            klr.Jumlah = dtr["Jumlah"].ToString();

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
