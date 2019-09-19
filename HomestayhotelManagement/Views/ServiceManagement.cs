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
    public partial class ServiceManagement : UserControl
    {
        #region Variable
        HomeStayClient serviceClient = new HomeStayClient();
        List<Service> lstService = new List<Service>();
        Service service = new Service();
        #endregion

        public ServiceManagement()
        {
            InitializeComponent();
            load_Service();

        }

        private static ServiceManagement _instance;
        public static ServiceManagement Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ServiceManagement();
                return _instance;
            }
        }

        private void ServiceManagement_Load(object sender, EventArgs e)
        {

        }


        #region Load dataGidView
        private void load_Service()
        {
            lstService = serviceClient.getAllService().ToList();

            if (lstService != null)
                dgvServiceManagement.DataSource = lstService;
        }
        #endregion

        #region Save Service
        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (ValidateInputData())
            {
                service = new Service()
                {
                    Name = txbServicename.Text,
                    Description = txbDescription.Text,
                    Price = Convert.ToDecimal(txbPriceService.Text),
                    
                };
                try
                {
                    bool complete = serviceClient.InsertService(service);
                    if (complete)
                        load_Service();
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

        #region Update Service
        private void btnUpdateService_Click(object sender, EventArgs e)
        {
            service.Name = txbServicename.Text;
            service.Description = txbDescription.Text;
            service.Price = Convert.ToDecimal(txbPriceService.Text);
            try
            {
                bool complete = serviceClient.UpdateService(service);
                if (complete)
                    load_Service();
                MessageBox.Show("Data Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region Delete Service
        private void btnDeleteService_Click(object sender, EventArgs e)
        {
            try
            {
                bool complete = serviceClient.DeleteService(service);
                if (complete)
                    load_Service();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region Serach
        private void btnSearchService_Click(object sender, EventArgs e)
        {
            lstService = serviceClient.FindService(txbSearchService.Text).ToList();
            dgvServiceManagement.DataSource = lstService;
        }
        #endregion

        #region Select RowGidview fill to From
        private void dgvServiceManagement_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvServiceManagement.Rows[e.RowIndex];

            service = (Service)dgvServiceManagement.Rows[e.RowIndex].DataBoundItem;

            txbServicename.Text = service.Name;
            txbDescription.Text = service.Description;
            txbPriceService.Text = service.Price.ToString();
        }
        #endregion

        #region clear Input data

        private void clearInputData()
        {
            List<TextBox> lstTextBoxs = grbService.Controls.OfType<TextBox>().ToList();
            foreach (TextBox tbx in lstTextBoxs)
                tbx.Text = string.Empty;
        }
        private void btnClearService_Click(object sender, EventArgs e)
        {
            clearInputData();
        }
        #endregion

        #region Validate Input Data
        private bool ValidateInputData()
        {
            List<TextBox> lstTextBoxs = grbInfo.Controls.OfType<TextBox>().ToList();
            //lstTextBoxs.AddRange(grbServiceInfomation.Controls.OfType<TextBox>().ToList());
            foreach (TextBox tbx in lstTextBoxs)
                if (string.IsNullOrWhiteSpace(tbx.Text))
                    return false;
            return true;
        }
        #endregion
    }
}
