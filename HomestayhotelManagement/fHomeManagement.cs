using HomestayhotelManagement.Model;
using HomestayhotelManagement.ServiceReference1;
using HomestayhotelManagement.Views;
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
    public partial class fHomeManagement : Form
    {
        public fHomeManagement()
        {
            InitializeComponent();
        }

        private Role RootRole = new Role() { RoleID = 9999, Name = "Root Administrator", Description = "Root Administrator" };
        private LoginUser loginUser;

        public LoginUser LoginUser { get => loginUser; set => loginUser = value; }

        private void fHomeManagement_Load(object sender, EventArgs e)
        {
            quảnLýToolStripMenuItem.Enabled = false;
            quảnLýPhòngToolStripMenuItem.Enabled = false;
            quảnLýPhânQuyềnToolStripMenuItem.Enabled = false;
            quảnLýDịchVụToolStripMenuItem.Enabled = false;
            quảnLýToolStripMenuItem.Visible = false;
            quảnLýPhòngToolStripMenuItem.Visible = false;
            quảnLýPhânQuyềnToolStripMenuItem.Visible = false;
            quảnLýDịchVụToolStripMenuItem.Visible = false;


            if (loginUser.UserName.ToLower() == "Root".ToLower() && loginUser.RoleID == 9999)
                OpeningAdmin();
            else if (loginUser.getLoginRole().Name.ToLower() == "Administrator".ToLower())
                OpeningAdmin();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
            switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            Application.Exit();
        }
        private void OpeningAdmin()
        {
            quảnLýToolStripMenuItem.Enabled = true;
            quảnLýPhòngToolStripMenuItem.Enabled = true;
            quảnLýPhânQuyềnToolStripMenuItem.Enabled = true;
            quảnLýDịchVụToolStripMenuItem.Enabled = true;
            quảnLýToolStripMenuItem.Visible = true;
            quảnLýPhòngToolStripMenuItem.Visible = true;
            quảnLýPhânQuyềnToolStripMenuItem.Visible = true;
            quảnLýDịchVụToolStripMenuItem.Visible = true;
        }
        
        private void loginform()
        {
            this.Hide();
            fLogin fl = new fLogin();
            fl.Show();
        }
        #region Master Layout
        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            loginform();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnlViews.Controls.Contains(ChangePassword.Instance))
            {
                pnlViews.Controls.Add(ChangePassword.Instance);
                ChangePassword.Instance.Dock = DockStyle.Fill;

                ChangePassword.Instance.BringToFront();
            }
            else
                ChangePassword.Instance.BringToFront();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnlViews.Controls.Contains(UserManagement.Instance))
            {
                pnlViews.Controls.Add(UserManagement.Instance);
                UserManagement.Instance.Dock = DockStyle.Fill;

                UserManagement.Instance.BringToFront();
            }
            else
                UserManagement.Instance.BringToFront();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnlViews.Controls.Contains(ServiceManagement.Instance))
            {
                pnlViews.Controls.Add(ServiceManagement.Instance);
                ServiceManagement.Instance.Dock = DockStyle.Fill;

                ServiceManagement.Instance.BringToFront();
            }
            else
                ServiceManagement.Instance.BringToFront();
        }

        private void quảnLýPhânQuyềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnlViews.Controls.Contains(RoleManagement.Instance))
            {
                pnlViews.Controls.Add(RoleManagement.Instance);
                RoleManagement.Instance.Dock = DockStyle.Fill;

                RoleManagement.Instance.BringToFront();
            }
            else
                RoleManagement.Instance.BringToFront();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!pnlViews.Controls.Contains(RoomManagement.Instance))
            {
                pnlViews.Controls.Add(RoomManagement.Instance);
                RoomManagement.Instance.Dock = DockStyle.Fill;

                RoomManagement.Instance.BringToFront();
            }
            else
                RoomManagement.Instance.BringToFront();
        }

        #endregion


    }
}
