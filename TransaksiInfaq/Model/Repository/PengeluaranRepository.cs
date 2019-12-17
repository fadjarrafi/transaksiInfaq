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
    public class PengeluaranRepository
    {
        private OleDbConnection _conn;
        public PengeluaranRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Pengeluaran klr)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into Pengeluaran (No_Faktur, Tanggal, Kode_pengurus, Total_keluar, keperluan, No_rekening)
                   values (@Kode_masuk, @Tanggal, @Kode_Pengurus, @Total_keluar, @Keperluan, @No_rekening)";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
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
            string sql = @"update Pengeluaranset No_Faktur=@Kode_masuk, Tanggal=@Tanggal, Kode_pengurus=@Kode_Pengurus, Total_keluar=@Total_keluar, keperluan=@Keperluan, No_rekening=@No_rekening";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
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
            string sql = @"delete from Pengeluaran where No_Faktur = @No_Faktur";

            // Membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
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
                string sql = @"select * from Pengeluaran 
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
