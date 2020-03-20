using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
using TransaksiInfaq.Model.Entity;
using TransaksiInfaq.Model.Context;
using System.Diagnostics;

namespace TransaksiInfaq.Model.Repository
{
    public class PengurusRepository
    {
        private MySqlConnection _conn;

        public PengurusRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Pengurus prs)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into pengurus values(@Kode_Pengurus, @Nama, @Alamat, @No_Telepon, @Username, @Password)";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Kode_Pengurus", prs.Kode_Pengurus);
                cmd.Parameters.AddWithValue("@Nama", prs.Nama);
                cmd.Parameters.AddWithValue("@Alamat", prs.Alamat);
                cmd.Parameters.AddWithValue("@No_Telepon", prs.No_Telepon);
                cmd.Parameters.AddWithValue("@Username", prs.Username);
                cmd.Parameters.AddWithValue("@Password", prs.Password);

                try
                {
                    // jalankan perintah INSERT dan tampung hasilnya ke dalam variabel result
                    result = cmd.ExecuteNonQuery();
                    Debug.Print("result " + result); // debug
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Update(Pengurus prs)
        {
            int result = 0;

            // Deklarasi perintah SQL
            string sql = @"update pengurus set Nama = @Nama, Alamat = @Alamat, No_Telepon = @No_Telepon, Username = @Username, Password = @Password where Kode_Pengurus = @Kode_Pengurus";

            // Membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Nama", prs.Nama);
                cmd.Parameters.AddWithValue("@Alamat", prs.Alamat);
                cmd.Parameters.AddWithValue("@No_Telepon", prs.No_Telepon);
                cmd.Parameters.AddWithValue("@Username", prs.Username);
                cmd.Parameters.AddWithValue("@Password", prs.Password);
                cmd.Parameters.AddWithValue("@Kode_Pengurus", prs.Kode_Pengurus);

                System.Diagnostics.Debug.Print("Query: " + cmd.CommandText);

                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update error: {0}", ex.Message);
                }
            }

            return result;
        }

        public int Delete(Pengurus prs)
        {
            int result = 0;

            // Deklarasi perintah SQL
            string sql = @"delete from pengurus where Kode_Pengurus = @Kode_Pengurus";

            // Membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Kode_Pengurus", prs.Kode_Pengurus);

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

        public List<Pengurus> ReadAll()
        {
            // Membuat objek collection list untuk menampung objek siswa
            List<Pengurus> list = new List<Pengurus>();

            try
            {
                // Deklarasi perintah SQL
                string sql = @"select * from pengurus";

                // Membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {

                    // Membuat ojek dtr (data reader) untuk menampung result set
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // looping untuk membaca tiap baris dari result set

                        while (dtr.Read())
                        {
                            // proses konversi dari row result set menjadi object
                            Pengurus prs = new Pengurus();
                            prs.Kode_Pengurus = dtr["Kode_Pengurus"].ToString();
                            prs.Nama = dtr["Nama"].ToString();
                            prs.Alamat = dtr["Alamat"].ToString();
                            prs.No_Telepon = dtr["No_Telepon"].ToString();
                            prs.Username = dtr["Username"].ToString();
                            prs.Password = dtr["Password"].ToString();

                            list.Add(prs);
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

        public List<Pengurus> ReadByNama(string Nama)
        {
            // Membuat objek collection list untuk menampung objek siswa
            List<Pengurus> listPengurus = new List<Pengurus>();

            try
            {
                // Deklarasi perintah SQL
                string sql = @"select * from pengurus where Nama like @Nama order by Nama";

                // Membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@Nama", "%" + Nama + "%");

                    // Membuat ojek dtr (data reader) untuk menampung result set
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // looping untuk membaca tiap baris dari result set

                        while (dtr.Read())
                        {
                            // proses konversi dari row result set menjadi object
                            Pengurus prs = new Pengurus();
                            prs.Kode_Pengurus = dtr["Kode_Pengurus"].ToString();
                            prs.Nama = dtr["Nama"].ToString();
                            prs.Alamat = dtr["Alamat"].ToString();
                            prs.No_Telepon = dtr["No_Telepon"].ToString();
                            prs.Username = dtr["Username"].ToString();
                            prs.Password = dtr["Password"].ToString();

                            listPengurus.Add(prs);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return listPengurus;

        }
    }

}
