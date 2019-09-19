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
using System.IO;

namespace HomestayhotelManagement.Views
{
    public partial class UserManagement : UserControl
    {
        #region Variable

        HomeStayClient serviceClient = new HomeStayClient();
        List<User> lstUser = new List<User>();
        User user = new User();
        #endregion
        public UserManagement()
        {
            InitializeComponent();
        }

        #region Form Master

        private static UserManagement _instance;
        public static UserManagement Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserManagement();
                return _instance;
            }
        }
        #endregion
        public void loaddgvUser()
        {
            lstUser = serviceClient.getAllUser().ToList();

            if (lstUser != null)
                dgvUserManagement.DataSource = lstUser;
        }
        private void UserManagement_Load(object sender, EventArgs e)
        {
            dtpBirthday.Value = dtpBirthday.MinDate;

            List<Role> lstRoles = new List<Role>();
            lstRoles.Insert(0, new Role() { RoleID = 0, Name = "< - Please select Roles - >" });
            lstRoles.AddRange(serviceClient.getAllRole());
            cbRole.DisplayMember = "Name";
            cbRole.ValueMember = "RoleID";
            cbRole.DataSource = lstRoles;

            cbRole.SelectedIndex = 0;
            loaddgvUser();
        }
        #region Search
        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            lstUser = serviceClient.FindUsers(txbSearch.Text).ToList();

            dgvUserManagement.DataSource = lstUser;
        }


        private void txbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)Keys.Enter)
            {
                btnSearchUser.PerformClick();
            }
        }
        #endregion

        #region Save User
        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            //Validate here
            if (ValidateInputData())
            {
                /* Prepare for data User */
                //Gender
                string gender = string.Empty;
                if (radMale.Checked)
                {
                    gender = "Male";
                }
                else if (radFemale.Checked)
                {
                    gender = "Female";
                }
                //Image
                saveImage(picImage.Tag.ToString(), txbUsername.Text);

                /* Create User for insert user */
                user = new User()
                {
                    UserName = txbUsername.Text,
                    UserPassword = new Binary() { Bytes = Encoding.UTF8.GetBytes(txbPassword.Text) },
                    FirstName = txbFirstname.Text,
                    LastName = txbLastname.Text,
                    Birthday = dtpBirthday.Value,
                    Gender = gender,
                    PhoneNumber = txbPhonenumber.Text,
                    Address = txbAddress.Text,
                    Email = txbEmail.Text,
                    Image = picImage.Tag.ToString(),
                };

                /* Insert User */
                try
                {
                    bool complete = serviceClient.InsertUser(user, (int)cbRole.SelectedValue);
                    if (complete)
                        loaddgvUser();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
                MessageBox.Show("Input data is wrong", "Input Error");
        }
        #endregion

        #region Update User
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {

            user.UserName = txbUsername.Text;
            user.UserPassword = new Binary() { Bytes = Encoding.UTF8.GetBytes(txbPassword.Text) };
            user.FirstName = txbFirstname.Text;
            user.LastName = txbLastname.Text;
            user.PhoneNumber = txbPhonenumber.Text;
            user.Address = txbAddress.Text;
            user.Email = txbEmail.Text;
            user.Birthday = dtpBirthday.Value;
            user.Image = picImage.Tag.ToString();
            //user.Gender
            if (radMale.Checked == true)
                user.Gender = "Male";
            else if (radFemale.Checked == true)
                user.Gender = "Female";

            try
            {
                bool complete = serviceClient.UpdateUser(user);
                if (complete)
                    loaddgvUser();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region Delete User
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                string linkToImage = user.Image;
                bool complete = serviceClient.DeleteUser(user);
                if (complete)
                {
                    DelImage(linkToImage);
                    clearInputData();
                    loaddgvUser();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        private void dgvUserManagement_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvUserManagement.Rows[e.RowIndex];

            user = (User)dgvUserManagement.Rows[e.RowIndex].DataBoundItem;

            txbUsername.Text = user.UserName;
            txbFirstname.Text = user.FirstName;
            txbLastname.Text = user.LastName;
            //.Value = user.Birthday.Value;
            txbPhonenumber.Text = user.PhoneNumber;
            txbAddress.Text = user.Address;
            txbEmail.Text = user.Email;
            //Image
            if (user.Image != null)
            {
                picImage.Image = new Bitmap(user.Image);
                picImage.Tag = user.Image;
            }

            if (user.Gender == null) { }
            else if (user.Gender.Equals("Male"))
                radMale.Checked = true;
            else if (user.Gender.Equals("Female"))
                radFemale.Checked = true;
            if (user.Birthday != null)
                dtpBirthday.Value = user.Birthday.GetValueOrDefault();
        }

        private void btnClearUser_Click(object sender, EventArgs e)
        {
            clearInputData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbRole.Items.Add(cbRole.Text);
        }

        private void picImage_Click(object sender, EventArgs e)
        {
            //string _Path = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose one picture";
            ofd.Filter = "Image files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //saveImage(ofd.FileName, out _Path);
                //if (_Path != null)
                //picImage.Image = ofd.FileName;
                //else
                //  ImageTextEdit.Text = "Error";

                //Image image = Image.FromFile(ofd.FileName);
                Bitmap bitmap = new Bitmap(ofd.FileName);
                picImage.Image = bitmap;
                picImage.Tag = ofd.FileName;
                //image.Dispose();
            }
        }

        #region Save Image
        private void saveImage(string linkToImageName, string username)
        {
            string testPath = Application.UserAppDataPath;
            string ImageName = Path.GetFileName(linkToImageName);
            string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), @"Images\User");
            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }
            string linkToSaveImage = Path.Combine(FolderPath, username + "_" + ImageName);
            picImage.Image.Save(linkToSaveImage);
            picImage.Tag = linkToSaveImage;
        }
        #endregion

        #region Delete Image
        private void DelImage(string ImagePath)
        {
            if (File.Exists(ImagePath))
                File.Delete(ImagePath);
        }
        #endregion
        private void clearInputData()
        {
            List<TextBox> lstTextBoxs = grbUserManagement.Controls.OfType<TextBox>().ToList();
            lstTextBoxs.AddRange(grbAccount.Controls.OfType<TextBox>().ToList());
            lstTextBoxs.AddRange(groupBox1.Controls.OfType<TextBox>().ToList());
            foreach (TextBox tbx in lstTextBoxs)
                tbx.Text = string.Empty;

            cbRole.SelectedIndex = 0;
            radMale.Checked = false;
            radMale.Checked = false;
            dtpBirthday.Value = dtpBirthday.MinDate;

            picImage.Image = null;
            picImage.Tag = null;
        }

        private bool ValidateInputData()
        {
            List<TextBox> lstTextBoxs = grbAccount.Controls.OfType<TextBox>().ToList();
            lstTextBoxs.AddRange(groupBox1.Controls.OfType<TextBox>().ToList());
            foreach (TextBox tbx in lstTextBoxs)
                if (string.IsNullOrWhiteSpace(tbx.Text))
                    return false;
            if (cbRole.SelectedIndex == 0)
                return false;
            if (radMale.Checked == false && radFemale.Checked == false)
                return false;
            if (dtpBirthday.Value <= dtpBirthday.MinDate || dtpBirthday.Value >= DateTime.Now)
                return false;

            if (picImage.Image == null || picImage.Tag == null)
                return false;
            return true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loaddgvUser();
        }
        #region Validate Email
        private void txbEmail_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex
             rMail = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            if (txbEmail.Text.Length > 0)
            {
                if (!rMail.IsMatch(txbEmail.Text))
                {
                    MessageBox.Show("invalid email adress", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbEmail.SelectAll();
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region Validate PhoneNumber
        private void txbPhonenumber_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex
            rMail = new System.Text.RegularExpressions.Regex(@"^\d{10,11}$");
            if (txbPhonenumber.Text.Length > 0)
            {
                if (!rMail.IsMatch(txbPhonenumber.Text))
                {
                    MessageBox.Show("Phone numbers must be between 10 and 11 digits", "Error phone number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txbPhonenumber.SelectAll();
                    e.Cancel = true;
                }
            }
        }
        #endregion
    }
}
