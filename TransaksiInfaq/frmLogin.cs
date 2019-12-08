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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void LoginUser()
        {
            try
            {
                OleDbConnection conn = null; // deklarasi objek connection

                try // penggunaan blok try-catch untuk penanganan error
                {
                    // atur ulang lokasi database yang disesuaikan dengan
                    // lokasi database perpustakaan Anda
                    string dbName = @"E:\infaq2\Database.mdb";

                    // deklarasi variabel connectionString, ref: https://www.connectionstrings.com/
                    string connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}", dbName);

                    conn = new OleDbConnection(connectionString); // buat objek connection
                    conn.Open(); // buka koneksi ke database
                }
                // jika terjadi error di blok try, akan ditangani langsung oleh blok catch
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                string sql;
                OleDbCommand cmd;
                OleDbDataAdapter da;

                DataSet ds = new DataSet("ds");

                sql = "select username, password from pengurus where username = '" + txtUsername.Text + "'";
                cmd = new OleDbCommand(sql, conn);
                da = new OleDbDataAdapter(cmd);

                da.Fill(ds);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    if (txtPassword.Text.ToLower().Trim() == ds.Tables[0].Rows[0]["password"].ToString().Trim().ToLower())
                    {
                        this.Hide();
                        txtPassword.Text = "";
                        frmMainMenu mainmenu = new frmMainMenu();
                        mainmenu.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password salah");
                        txtPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("User id tidak terdaftar");
                    txtUsername.Focus();
                }
                conn.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            LoginUser();
        }
    }
}
