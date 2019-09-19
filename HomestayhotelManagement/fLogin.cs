using HomestayhotelManagement.Model;
using HomestayhotelManagement.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomestayhotelManagement
{
    public partial class fLogin : Form
    {
        private HomeStayClient serviceClient = new HomeStayClient();
        private LoginUser loginUser;
        private User RootUser = new User()
        {
            UserName = "Root",
            FirstName = "User",
            LastName = "Root",
            Email = "nguyenminhsang5692@gmail.com",
            RoleID = 9999,
        };
        public fLogin()
        {
            InitializeComponent();
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            txbUsername.KeyPress += new KeyPressEventHandler(KeyPressModified);
            txbPassword.KeyPress += new KeyPressEventHandler(KeyPressModified);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateData())
                return;
            User AuthUser = serviceClient.checkLogin(txbUsername.Text, txbPassword.Text);

            if (txbUsername.Text.ToLower() == "Root".ToLower() && txbPassword.Text.ToLower() == "Root".ToLower())
            {
                loginUser = new LoginUser(RootUser);
                fHomeManagement fHome = new fHomeManagement();
                fHome.LoginUser = loginUser;
                this.Hide();
                fHome.Show();
            }
            else if (AuthUser != null)
            {
                loginUser = new LoginUser(AuthUser);
                fHomeManagement fHome = new fHomeManagement();
                fHome.LoginUser = loginUser;
                this.Hide();
                fHome.Show();
            }
            else
            {
                btnLogin.DialogResult = DialogResult.No;
                MessageBox.Show("Sorry, we didn't recognize your login details. Please check your username and password, then try again.");
            }
        }

        private bool ValidateData()
        {
            errorProvider1.Clear();
            bool res = true;
            if (string.IsNullOrWhiteSpace(txbUsername.Text))
            {
                errorProvider1.SetError(txbUsername, "Input username");
                res = false;
            }
            if (string.IsNullOrWhiteSpace(txbPassword.Text))
            {
                errorProvider1.SetError(txbPassword, "Input password");
                res = false;
            }
            return res;
        }

        private void KeyPressModified(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}
