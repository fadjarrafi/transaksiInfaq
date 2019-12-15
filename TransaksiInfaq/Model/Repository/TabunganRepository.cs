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
    public class TabunganRepository
    {

        private OleDbConnection _conn;

        public TabunganRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Tabungan tbg)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into Tabungan (No_Rekening, Bank, Saldo)
                   values (@No_Rekening, @Bank, @Saldo)";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@No_Rekering", tbg.No_rekening);
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
            string sql = @"update Tabungan set No_Rekening=@No_Rekening, Bank=@Bank, Saldo=@Saldo";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@No_Rekering", tbg.No_rekening);
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

        public int Delete(Tabungan tbg)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"delete Tabungan where No_Rekening=@No_Rekening";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@No_Rekering", tbg.No_rekening);

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
    }
}
