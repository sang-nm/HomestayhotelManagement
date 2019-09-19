using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomestayhotelManagement.Views
{
    public partial class ChangePassword : UserControl
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private static ChangePassword _instance;
        public static ChangePassword Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ChangePassword();
                return _instance;
            }
        }
 
        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        
    }
}
