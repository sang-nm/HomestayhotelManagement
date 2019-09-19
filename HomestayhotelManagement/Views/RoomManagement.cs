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
using System.Drawing.Imaging;

namespace HomestayhotelManagement.Views
{
    public partial class RoomManagement : UserControl
    {
        public RoomManagement()
        {
            InitializeComponent();
        }

        #region Variable

        HomeStayClient serviceClient = new HomeStayClient();
        List<Room> lstRooms = new List<Room>();
        Room room = new Room();
        List<Service> lstServices = new List<Service>();
        #endregion

        #region Fill to Main
        private static RoomManagement _instance;
        public static RoomManagement Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RoomManagement();
                return _instance;
            }
        }
        #endregion
        private void RoomManagement_Load(object sender, EventArgs e)
        {
            load_Rooms();
            clearInputData();
            clbService.DataSource = serviceClient.getAllService();
            clbService.DisplayMember = "Name";
            clbService.ValueMember = "ServiceID";
        }
        #region Validate Input Data
        private bool ValidateInputData()
        {
            List<TextBox> lstTextBoxs = grbRoomInfo.Controls.OfType<TextBox>().ToList();
            foreach (TextBox tbx in lstTextBoxs)
                if (string.IsNullOrWhiteSpace(tbx.Text))
                    return false;
            if (clbService.CheckedItems.Count == 0)
                return false;
            if (flpanelImage.Controls.Count == 0)
                return false;
            return true;
        }
        #endregion

        #region LOAD DataGidview
        private void load_Rooms()
        {
            lstRooms = serviceClient.getAllRoom().ToList();

            if (lstRooms != null)
                dgvRooms.DataSource = lstRooms;
        }
        #endregion

        #region SAVE ROOM
        private void btnSaveRoom_Click(object sender, EventArgs e)
        {
            Service[] services = clbService.CheckedItems.Cast<Service>().ToArray();

            if (ValidateInputData())
            {
                room = new Room()
                {
                    RoomNumber = Convert.ToInt32(txbRoomNumber.Text),
                    Description = txbDescription.Text,
                };
                try
                {
                    int insertedRoomID = serviceClient.InsertRoom(room, services);
                    if (insertedRoomID != 0)
                    {
                        saveImage(insertedRoomID);
                        load_Rooms();
                        MessageBox.Show("Success!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
                MessageBox.Show("Input data wrong!", "Error");

        }
        #endregion

        #region UPDATE ROOM
        private void btnUpdateRoom_Click(object sender, EventArgs e)
        {
            Service[] services = clbService.CheckedItems.Cast<Service>().ToArray();
            if (ValidateInputData())
            {
                room.RoomNumber = Convert.ToInt32(txbRoomNumber.Text);
                room.Description = txbDescription.Text;
                try
                {
                    int updatedRoomID = serviceClient.UpdateRoom(room, services);
                    if (updatedRoomID != 0)
                    {
                        saveImage(updatedRoomID);
                        load_Rooms();
                        MessageBox.Show("Success!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
            else
                MessageBox.Show("Input data wrong!", "Error");

        }
        #endregion

        #region DELETE ROOM
        private void btnDeletRoom_Click(object sender, EventArgs e)
        {
            try
            {
                serviceClient.DeleteAllRoom_ServicebyRoomID(room.RoomID);
                serviceClient.DeleteAllImagebyRoomID(room.RoomID);

                bool complete = serviceClient.DeleteRoom(room);
                if (complete)
                {
                    MessageBox.Show("Delete Success");
                }
                load_Rooms();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region CLEAR FORM

        private void clearInputData()
        {
            List<TextBox> lstTextBoxs = grbRoomInfo.Controls.OfType<TextBox>().ToList();
            lstTextBoxs.AddRange(grbRoomManagement.Controls.OfType<TextBox>().ToList());
            foreach (TextBox tbx in lstTextBoxs)
                tbx.Text = string.Empty;
            foreach (int index in clbService.CheckedIndices)
            {
                clbService.SetItemCheckState(index, CheckState.Unchecked);
            }
            flpanelImage.Controls.Clear();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            load_Rooms();
            clearInputData();
        }

        #endregion

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            lstRooms = serviceClient.FindRoom(txbSearch.Text).ToList();
            dgvRooms.DataSource = lstRooms;
        }

        #region Select RowGidview fill to From
        private void dgvRooms_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < clbService.Items.Count; i++)
                clbService.SetItemCheckState(clbService.Items.IndexOf(clbService.Items[i]), CheckState.Unchecked);
            DataGridViewRow row = dgvRooms.Rows[e.RowIndex];

            room = (Room)dgvRooms.Rows[e.RowIndex].DataBoundItem;

            txbRoomNumber.Text = room.RoomNumber.ToString();
            txbDescription.Text = room.Description;

            // load checked service
            lstServices = serviceClient.GetAllServiceByRoomID(room.RoomID).ToList();
            for (int i = 0; i < clbService.Items.Count; i++)
                if (lstServices.Exists(x => x.ServiceID == ((Service)clbService.Items[i]).ServiceID))
                    clbService.SetItemCheckState(clbService.Items.IndexOf(clbService.Items[i]), CheckState.Checked);
            // load Image
            loadImage(room.RoomID);
        }
        #endregion

        private void flowLayoutPanel1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose one picture";
            ofd.Filter = "Image files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] files = ofd.FileNames;
                foreach (string imageFile in files)
                {
                    PictureBox eachPictureBox = new PictureBox();
                    eachPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    eachPictureBox.Size = new Size(100, 100);
                    eachPictureBox.Image = System.Drawing.Image.FromFile(imageFile);
                    eachPictureBox.Tag = imageFile;
                    eachPictureBox.Click += PicBox_Click;
                    flpanelImage.Controls.Add(eachPictureBox);
                }
            }
        }

        private void saveImage(int RoomID)
        {
            List<ServiceReference1.Image> lstImages = new List<ServiceReference1.Image>();

            foreach (PictureBox pb in flpanelImage.Controls.OfType<PictureBox>())
            {
                string ImageName = Path.GetFileName(pb.Tag.ToString());
                string FolderPath = Path.Combine(Directory.GetCurrentDirectory(), @"Images\Room");
                if (!Directory.Exists(FolderPath))
                {
                    Directory.CreateDirectory(FolderPath);
                }
                string linkToSaveImage = Path.Combine(FolderPath, RoomID + "_" + ImageName);
                pb.Image.Save(linkToSaveImage);

                ServiceReference1.Image image = new ServiceReference1.Image()
                {
                    RoomID = RoomID,
                    Name = linkToSaveImage,
                };
                lstImages.Add(image);
            }
            serviceClient.DeleteAllImagebyRoomID(RoomID);
            serviceClient.InsertListImage(lstImages.ToArray());
        }

        private void loadImage(int RoomID)
        {
            flpanelImage.Controls.Clear();

            List<ServiceReference1.Image> lstImage = serviceClient.GetAllImagebyRoomID(RoomID).ToList();
            List<string> files = new List<string>();
            foreach (var item in lstImage)
            {
                files.Add(item.Name);
            }
            foreach (string imageFile in files)
            {
                PictureBox eachPictureBox = new PictureBox();
                eachPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                eachPictureBox.Size = new Size(100, 100);
                eachPictureBox.Image = System.Drawing.Image.FromFile(imageFile);
                eachPictureBox.Tag = imageFile;
                eachPictureBox.Click += PicBox_Click;
                flpanelImage.Controls.Add(eachPictureBox);
            }
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            flpanelImage.Controls.Remove((Control)sender);
        }
    }
}

