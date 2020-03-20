using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using TransaksiInfaq.Controller;

namespace TransaksiInfaq.View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserController controller = new UserController();

            bool isValidUser = controller.IsValidUser(txtUsername.Text, txtPassword.Text);

            if (isValidUser)
            {
                this.DialogResult = DialogResult.OK;
                FrmMainMenu fmain = new FrmMainMenu();
                fmain.ShowDialog();
                this.Close();
            }
            
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
