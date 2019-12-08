using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TransaksiInfaq
{
    public partial class frmDataPengurus : Form
    {
        public frmDataPengurus()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private OleDbConnection GetOpenConnection()
        {
            OleDbConnection connect = null; // deklarasi objek connection

            try // penggunaan blok try-catch untuk penanganan error
            {
                // atur ulang lokasi database yang disesuaikan dengan
                // lokasi database perpustakaan Anda
                string dbName = @"E:\infaq2\Database.mdb";

                // deklarasi variabel connectionString, ref: https://www.connectionstrings.com/
                string connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", dbName);

                connect = new OleDbConnection(connectionString); // buat objek connection
                connect.Open(); // buka koneksi ke database
            }
            // jika terjadi error di blok try, akan ditangani langsung oleh blok catch
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

            return connect;
        }

        private void InisialisasiListView()
        {
            lvwDataPengurus.View = View.Details;
            lvwDataPengurus.FullRowSelect = true;
            lvwDataPengurus.GridLines = true;

            lvwDataPengurus.Columns.Add("No.", 30, HorizontalAlignment.Center);
            lvwDataPengurus.Columns.Add("Kode Pengurus", 70, HorizontalAlignment.Center);
            lvwDataPengurus.Columns.Add("Nama Lengkap", 90, HorizontalAlignment.Center);
            lvwDataPengurus.Columns.Add("Alamat", 190, HorizontalAlignment.Center);
            lvwDataPengurus.Columns.Add("No Telepon", 90, HorizontalAlignment.Center);
            lvwDataPengurus.Columns.Add("Username", 90, HorizontalAlignment.Center);
            lvwDataPengurus.Columns.Add("Password", 90, HorizontalAlignment.Center);
        }

        private void BtnRefreshDataPengurus_Click(object sender, EventArgs e)
        {
            lvwDataPengurus.Clear();
            // membuat objek Connection, sekaligus buka koneksi ke database
            OleDbConnection connect = GetOpenConnection();

            // deklarasi variabel sql untuk menampung perintah SELECT
            string sql = @"select * from Pengurus ";

            // membuat objek Command untuk mengeksekusi perintah SQL
            OleDbCommand cmd = new OleDbCommand(sql, connect);

            // membuat objek DataReader untuk menampung hasil perintah SELECT
            OleDbDataReader dtr = cmd.ExecuteReader(); // eksekusi perintah SELECT

            while (dtr.Read()) // gunakan perulangan utk menampilkan data ke listview
            {
                var noUrut = lvwDataPengurus.Items.Count + 1;

                var item = new ListViewItem(noUrut.ToString());
                item.SubItems.Add(dtr["Kode_Pengurus"].ToString());
                item.SubItems.Add(dtr["Nama"].ToString());
                item.SubItems.Add(dtr["Alamat"].ToString()); 
                item.SubItems.Add(dtr["No_Telepon"].ToString());
                item.SubItems.Add(dtr["Username"].ToString());
                item.SubItems.Add(dtr["Password"].ToString());


                lvwDataPengurus.Items.Add(item);
            }

            // setelah selesai digunakan, 
            // segera hapus objek datareader, command dan connection dari memory
            dtr.Dispose();
            cmd.Dispose();
            connect.Dispose();
        }

        private void BtnSimpanDataPengurus_Click(object sender, EventArgs e)
        {
            var result = 0;

            // validasi no anggota harus diisi
            if (txtKodePengurusInsert.Text.Length == 0)
            {
                MessageBox.Show("Kode Pengurus harus diisi !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                txtKodePengurusInsert.Focus();
                return;
            }

            // validasi nama harus diisi
            if (txtNamaInsert.Text.Length == 0)
            {
                MessageBox.Show("Nama harus diisi !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                txtNamaInsert.Focus();
                return;
            }

            // membuat objek Connection, sekaligus buka koneksi ke database
            OleDbConnection conn = GetOpenConnection();

            // deklarasi variabel sql untuk menampung perintah INSERT
            var sql = @"insert into Pengurus (Kode_Pengurus, Nama, Alamat, No_Telepon, Username, Password)
                values (@Kode_Pengurus, @Nama, @Alamat, @No_Telepon, @Username, @Password)";

            // membuat objek Command untuk mengeksekusi perintah SQL
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            try
            {
                // set parameter untuk nama, angkatan dan npm
                cmd.Parameters.AddWithValue("@?", txtKodePengurusInsert.Text);
                cmd.Parameters.AddWithValue("@?", txtNamaInsert.Text);
                cmd.Parameters.AddWithValue("@?", rtxtAlamatInsert.Text);
                cmd.Parameters.AddWithValue("@?", txtNoTelpInsert.Text);
                cmd.Parameters.AddWithValue("@?", txtUsernameInsert.Text);
                cmd.Parameters.AddWithValue("@?", txtPasswordInsert.Text);
                
                result = cmd.ExecuteNonQuery(); // eksekusi perintah INSERT
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
            }

            if (result > 0)
            {
                MessageBox.Show("Data pengurus berhasil disimpan !", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                // reset form
                txtKodePengurusInsert.Clear();
                txtNamaInsert.Clear();
                rtxtAlamatInsert.Clear();
                txtNoTelpInsert.Clear();
                txtUsernameInsert.Clear();
                txtPasswordInsert.Clear();
                txtKodePengurusInsert.Focus();
            }
            else
                MessageBox.Show("Data pengurus gagal disimpan !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

            // setelah selesai digunakan, 
            // segera hapus objek connection dari memory
            conn.Dispose();
        }

        private void BtnCariDataPengurus_Click(object sender, EventArgs e)
        {
            // validasi no anggota harus diisi
            if (txtKodePengurusEdit.Text.Length == 0)
            {
                MessageBox.Show("Kode Pengurus harus !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

                txtKodePengurusEdit.Focus();
                return;
            }

            // membuat objek Connection, sekaligus buka koneksi ke database
            OleDbConnection conn = GetOpenConnection();

            // deklarasi variabel sql untuk menampung perintah SELECT
            string sql = @"select Kode_Pengurus, Nama,  Alamat, No_Telepon, Username, Password
                    from Pengurus 
                    where Kode_Pengurus = @Kode_Pengurus";

            // membuat objek Command untuk mengeksekusi perintah SQL
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Kode_Pengurus", txtKodePengurusEdit.Text);

            // membuat objek DataReader untuk menampung hasil perintah SELECT
            OleDbDataReader dtr = cmd.ExecuteReader(); // eksekusi perintah SELECT

            if (dtr.Read()) // data ditemukan
            {
                // tampilkan nilainya ke textbox
                txtKodePengurusEdit.Text = dtr["Kode_Pengurus"].ToString();
                txtNamaEdit.Text = dtr["Nama"].ToString();
                rtxtAlamatEdit.Text = dtr["Alamat"].ToString();
                txtNamaEdit.Text = dtr["No_Telepon"].ToString();
            }
            else
                MessageBox.Show("Data pengurus tidak ditemukan !", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            // setelah selesai digunakan, 
            // segera hapus objek datareader, command dan connection dari memory
            dtr.Dispose();
            cmd.Dispose();
            conn.Dispose();
        }

        private void BtnEditDataPengurus_Click(object sender, EventArgs e)
        {
            var result = 0;

            // validasi npm harus diisi
            if (txtKodePengurusEdit.Text.Length == 0)
            {
                MessageBox.Show("No Anggota harus !!!", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                txtKodePengurusEdit.Focus();
                return;
            }

            // validasi nama harus diisi
            if (txtNamaEdit.Text.Length == 0)
            {
                MessageBox.Show("Nama harus !!!", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                txtNamaEdit.Focus();
                return;
            }
            // membuat objek Connection, sekaligus buka koneksi ke database
            OleDbConnection conn = GetOpenConnection();

            // deklarasi variabel sql untuk menampung perintah UPDATE
            string sql = @"update Pengurus set Kode_Pengurus=@Kode_Pengurus, Nama=@Nama, Alamat=@Alamat, No_Telp=@No_Telp, Username=@Username, Password=@Password
                    where Kode_Pengurus=@Kode_Pengurus";

            // membuat objek Command untuk mengeksekusi perintah SQL
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            try
            {
                // set parameter untuk nama, angkatan dan npm
                cmd.Parameters.AddWithValue("@Kode_Pengurus", txtKodePengurusEdit.Text);
                cmd.Parameters.AddWithValue("@Nama_Lengkap", txtNamaEdit.Text);
                cmd.Parameters.AddWithValue("@Alamat", rtxtAlamatEdit.Text);
                cmd.Parameters.AddWithValue("@No_Telepon", txtNoTelpEdit.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsernameEdit.Text);
                cmd.Parameters.AddWithValue("@Password", txtPasswordEdit.Text);
                

                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
            }

            if (result > 0)
            {
                MessageBox.Show("Data anggota berhasil diupdate !", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                // reset form
                txtKodePengurusInsert.Clear();
                txtNamaInsert.Clear();
                rtxtAlamatInsert.Clear();
                txtNoTelpInsert.Clear();
                txtUsernameInsert.Clear();
                txtPasswordInsert.Clear();
                txtKodePengurusInsert.Focus();
            }
            else
                MessageBox.Show("Data anggota gagal diupdate !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

            // setelah selesai digunakan, 
            // segera hapus objek connection dari memory
            conn.Dispose();
        }

        private void BtnHapusDataPengurus_Click(object sender, EventArgs e)
        {
            var result = 0;

            // validasi npm harus diisi
            if (txtKodePengurusEdit.Text.Length == 0)
            {
                MessageBox.Show("No Anggota harus !!!", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                txtKodePengurusEdit.Focus();
                return;
            }

            // validasi nama harus diisi
            if (txtNamaEdit.Text.Length == 0)
            {
                MessageBox.Show("Nama harus !!!", "Informasi", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);

                txtNamaEdit.Focus();
                return;
            }
            // membuat objek Connection, sekaligus buka koneksi ke database
            OleDbConnection conn = GetOpenConnection();

            // deklarasi variabel sql untuk menampung perintah UPDATE
            string sql = @"delete Kode_Pengurus=@Kode_Pengurus, Nama=@Nama, Alamat=@Alamat, No_Telp=@No_Telp, Username=@Username, Password=@Password
                    from Pengurus
                    where Kode_Pengurus=@Kode_Pengurus";

            // membuat objek Command untuk mengeksekusi perintah SQL
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            try
            {
                // set parameter untuk nama, angkatan dan npm
                cmd.Parameters.AddWithValue("@Kode_Pengurus", txtKodePengurusEdit.Text);
                cmd.Parameters.AddWithValue("@Nama_Lengkap", txtNamaEdit.Text);
                cmd.Parameters.AddWithValue("@Alamat", rtxtAlamatEdit.Text);
                cmd.Parameters.AddWithValue("@No_Telepon", txtNoTelpEdit.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsernameEdit.Text);
                cmd.Parameters.AddWithValue("@Password", txtPasswordEdit.Text);


                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            finally
            {
                cmd.Dispose();
            }

            if (result > 0)
            {
                MessageBox.Show("Data anggota berhasil dihapus !", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                // reset form
                txtKodePengurusInsert.Clear();
                txtNamaInsert.Clear();
                rtxtAlamatInsert.Clear();
                txtNoTelpInsert.Clear();
                txtUsernameInsert.Clear();
                txtPasswordInsert.Clear();
                txtKodePengurusInsert.Focus();
            }
            else
                MessageBox.Show("Data anggota gagal dihapus !!!", "Informasi", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);

            // setelah selesai digunakan, 
            // segera hapus objek connection dari memory
            conn.Dispose();
        }

        private void BtnKembaliDataPengurus_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMainMenu frmMainMenu = new frmMainMenu();
            frmMainMenu.ShowDialog();
        }
    }
}
