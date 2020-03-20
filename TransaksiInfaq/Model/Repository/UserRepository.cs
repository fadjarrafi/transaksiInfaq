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
    public class UserRepository
    {
       
            // deklarsi objek connection
            private MySqlConnection _conn;

            // constructor
            public UserRepository(DbContext context)
            {
                // inisialisasi objek connection
                _conn = context.Conn;
            }

            public bool IsValidUser(string Username, string Password)
            {
                bool result = false;

                string sql = @"select count(*) as row_count
                           from pengurus
                           where Username = @Username and Password = @Password";

                // membuat objek command menggunakan blok using
                using (MySqlCommand cmd = new MySqlCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);

                    // membuat objek dtr (data reader) untuk menampung result set (hasil perintah SELECT)
                    using (MySqlDataReader dtr = cmd.ExecuteReader())// TO DO repairing Unhandled Exception: ExecuteReader need open connection
                    {
                        // panggil method Read untuk mendapatkan baris dari result set
                        if (dtr.Read())
                        {
                            result = Convert.ToInt32(dtr["row_count"]) > 0;
                        }
                    }
                }

                return result;
            }
        
    }
}
