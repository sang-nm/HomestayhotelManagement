using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomestayhotelManagement.ServiceReference1;

namespace HomestayhotelManagement.Views
{
    public partial class RoleManagement : UserControl
    {
        #region Variable
        HomeStayClient serviceClient = new HomeStayClient();
        List<Role> lstRole = new List<Role>();
        Role role = new Role();
        #endregion
        public RoleManagement()
        {
            InitializeComponent();
            load_dgvRole();
        }
        private static RoleManagement _instance;
        public static RoleManagement Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RoleManagement();
                return _instance;
            }
        }
        public void load_dgvRole()
        {
            lstRole = serviceClient.getAllRole().ToList();

            if (lstRole != null)
                dgvRole.DataSource = lstRole;
        }

        #region Save Role
        private void btnAdd_Click(object sender, EventArgs e)
        {
            role = new Role()
            {
                Name = txbRoleName.Text,
                Description = txbDecription.Text,

            };
            try
            {
                bool complete = serviceClient.InsertRole(role);
                if (complete)
                    load_dgvRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region Update Role
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            role.Name = txbRoleName.Text;
            role.Description = txbDecription.Text;
            try
            {
                bool complete = serviceClient.UpdateRole(role);
                if (complete)
                    load_dgvRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region Delete Role
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                bool complete = serviceClient.DeleteRole(role);
                if (complete)
                    load_dgvRole();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region Select Row Datagidview fill to form
        private void dgvRole_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvRole.Rows[e.RowIndex];

            role = (Role)dgvRole.Rows[e.RowIndex].DataBoundItem;

            txbRoleName.Text = role.Name;
            txbDecription.Text = role.Description;
        }

        #endregion

        #region Search Role
        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstRole = serviceClient.FindRoles(txbSearch.Text).ToList();

            dgvRole.DataSource = lstRole;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            load_dgvRole();
        }

        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnSearch.PerformClick();
        }
    }
    #endregion
}

