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
    public class PengurusRepository
    {
        private OleDbConnection _conn;

        public PengurusRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Pengurus prs)
        {
            int result = 0;

            // deklarasi perintah SQL
            string sql = @"insert into Pengurus (Kode_Pengurus, Nama, Alamat, No_Telepon, Username, Password)
                   values (@Kode_Pengurus, @Nama, @Alamat, @No_Telepon, @Username, @Password)";

            // membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
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
            string sql = @"update Pengurus set Nama=@Nama, Alamat=@Alamat,
                           No_Telepon=@No_Telepon, Username=@Username, Password=@Password where Kode_Pengurus=@Kode_Pengurus";

            // Membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
            {
                // mendaftarkan parameter dan mengeset nilainya
                cmd.Parameters.AddWithValue("@Nama", prs.Nama);
                cmd.Parameters.AddWithValue("@Alamat", prs.Alamat);
                cmd.Parameters.AddWithValue("@No_Telepon", prs.No_Telepon);
                cmd.Parameters.AddWithValue("@Username", prs.Username);
                cmd.Parameters.AddWithValue("@Password", prs.Password);
                cmd.Parameters.AddWithValue("@Kode_Pengurus", prs.Kode_Pengurus);

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
            string sql = @"delete from Pengurus where Kode_Pengurus = @Kode_Pengurus";

            // Membuat objek command menggunakan blok using
            using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
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

        public List<Pengurus> ReadByNama(string nama)
        {
            // Membuat objek collection list untuk menampung objek siswa
            List<Pengurus> list = new List<Pengurus>();

            try
            {
                // Deklarasi perintah SQL
                string sql = @"select Kode_Pengurus, Nama, Alamat, No_Telepon from Pengurus where Nama like @Nama order by Nama asc";

                // Membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@Nama", "%" + nama + "%");

                    // Membuat ojek dtr (data reader) untuk menampung result set
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // looping untuk membaca tiap baris dari result set

                        while (dtr.Read())
                        {
                            // proses konversi dari row result set menjadi object
                            Pengurus prs = new Pengurus();
                            prs.Kode_Pengurus= dtr["Kode_Pengurus"].ToString();
                            prs.Nama = dtr["Nama"].ToString();
                            prs.Alamat = dtr["Alamat"].ToString();
                            prs.No_Telepon = dtr["No_Telepon"].ToString();
                            //prs.Username = dtr["Username"].ToString();
                            //prs.Password = dtr["Password"].ToString();

                            list.Add(prs);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByNama error: {0}", ex.Message);
            }

            return list;
        }

        public Pengurus ReadByKode_Pengurus(string Kode_Pengurus)
        {
            // Membuat object dari class siswa
            Pengurus prs = new Pengurus();

            try
            {
                // Deklarasi perintah SQL
                string sql = @"select*from Pengurus where Kode_Pengurus like @Kode_pengurus order by Nama asc";

                // Membuat objek command menggunakan blok using
                using (OleDbCommand cmd = new OleDbCommand(sql, _conn))
                {
                    // mendaftarkan parameter dan mengeset nilainya
                    cmd.Parameters.AddWithValue("@Kode_Pengurus", "%" + Kode_Pengurus + "%");

                    // Membuat ojek dtr (data reader) untuk menampung result set
                    using (OleDbDataReader dtr = cmd.ExecuteReader())
                    {
                        // looping untuk membaca tiap baris dari result set

                        while (dtr.Read())
                        {
                            // proses konversi dari row result set menjadi object
                            // tidak memakai collection list karena 1 nisn 1 siswa
                            prs.Kode_Pengurus = dtr["Kode_Pengurus"].ToString();
                            prs.Nama = dtr["Nama"].ToString();
                            prs.Alamat = dtr["Alamat"].ToString();
                            prs.No_Telepon= dtr["No_Telepon"].ToString();
                            prs.Username = dtr["Username"].ToString();
                            prs.Password = dtr["Password"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByKode_Pengurus error: {0}", ex.Message);
            }

            return prs;
        }

    }

}
