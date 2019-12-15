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
    public class BarangRepository
    {
        private OleDbConnection _conn;

        public BarangRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Barang brg)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into Barang (Kode_Barang, Nama, Harga)
                   values (@Kode_Barang, @Nama, @Harga)";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Kode_Barang", brg.Kode_Barang);
                cmd.Parameters.AddWithValue("@Nama", brg.Nama_Barang);
                cmd.Parameters.AddWithValue("@Harga", brg.Harga);

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

        public int Update(Barang brg)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"update Barang set Nama=@Nama, Harga=@Harga where Kode_Barang=@Kode_Barang";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Kode_Barang", brg.Kode_Barang);
                cmd.Parameters.AddWithValue("@Nama", brg.Nama_Barang);
                cmd.Parameters.AddWithValue("@Harga", brg.Harga);

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

        public int Delete(Barang brg)
        {
            int result = 0;

            // Deklarasi perintah SQL
            string sql = @"delete from Barang where Kode_Barang = @Kode_Barang";

            // Membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Kode_Barang", brg.Kode_Barang);

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

        public List<Barang> ReadAll()
        {
            // membuat objek collection untuk menampung objek mahasiswa
            List<Barang> list = new List<Barang>();

            try
            {
                // deklarasi perintah SQL
                string sql = @"select Kode_Barang, Nama, Harga 
                        from Barang 
                        order by Nama";

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
                            Barang brg = new Barang();
                            brg.Kode_Barang = dtr["Kode_Barang"].ToString();
                            brg.Nama_Barang = dtr["Nama"].ToString();
                            brg.Harga = dtr["Harga"].ToString();

                            // tambahkan objek mahasiswa ke dalam collection
                            list.Add(brg);
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
