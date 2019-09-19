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
    public partial class Reservation : UserControl
    {
        public Reservation()
        {
            InitializeComponent();
            //loadRoom();
        }


        private static Reservation _instance;
        public static Reservation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Reservation();
                return _instance;
            }
        }

        private void Reservation_Load(object sender, EventArgs e)
        {

        }

        //void loadRoom()
        //{
        //    Button oldbtn = new Button()
        //    { Width = 0, Height = 0, Location = new Point(0, 0) };

        //    for (int i = 0; i < Room.Column; i++)
        //    {
        //        for (int j = 0; j < Room.Rows; j++)
        //        {
        //            Button btn = new Button() { Width = Room.RoomWidth, Height = Room.RoomHeight };
        //            btn.Location = new Point(oldbtn.Location.X + oldbtn.Width, oldbtn.Location.Y);

        //            flpRooms.Controls.Add(btn);

        //            oldbtn = btn;

        //        }

        //    }
        //}
    }
}
