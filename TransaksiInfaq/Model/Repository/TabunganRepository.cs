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
    public class TabunganRepository
    {

        private MySqlConnection _conn;

        public TabunganRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Tabungan tbg)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into tabungan values (@No_Rekening, @Bank, @Saldo)";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@No_Rekening", tbg.No_rekening);
                cmd.Parameters.AddWithValue("@Bank", tbg.Bank);
                cmd.Parameters.AddWithValue("@Saldo", tbg.Saldo);

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

        public int Update(Tabungan tbg)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update tabungan set Bank=@Bank, Saldo=@Saldo where No_Rekening=@No_Rekening";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Bank", tbg.Bank);
                cmd.Parameters.AddWithValue("@Saldo", tbg.Saldo);
                cmd.Parameters.AddWithValue("@No_Rekening", tbg.No_rekening);

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

        public int Delete(Tabungan tbg)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete from tabungan where No_Rekening=@No_Rekening";

            // membuat objek command menggunakan blok using
            using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@No_Rekening", tbg.No_rekening);

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

        public List<Tabungan> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Tabungan> list = new List<Tabungan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from tabungan 
                        order by No_rekening";

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
                            Tabungan tbg = new Tabungan();
                            tbg.No_rekening = dtr["No_Rekening"].ToString();
                            tbg.Bank = dtr["Bank"].ToString();
                            tbg.Saldo = dtr["Saldo"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(tbg);
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

        public List<Tabungan> ReadByNoRekening(string No_rekening)
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Tabungan> list = new List<Tabungan>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select * from tabungan where No_rekening like @No_rekening order by No_rekening";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {

                    cmd.Parameters.AddWithValue("@No_rekening", "%" + No_rekening + "%");
                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        while (dtr.Read())
                        {
                            // proses konversi dari row result set ke object
                            Tabungan tbg = new Tabungan();
                            tbg.No_rekening = dtr["No_rekening"].ToString();
                            tbg.Bank = dtr["Bank"].ToString();
                            tbg.Saldo = dtr["Saldo"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(tbg);
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
