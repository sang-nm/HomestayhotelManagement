using HomestayhotelManagement.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomestayhotelManagement.Model
{
    public class LoginUser
    {
        private HomeStayClient client = new HomeStayClient();
        private string _UserName;
        private string _FirstName;
        private string _LastName;
        private string _Email;
        private int _RoleID;
        private string _Image;

        public string UserName { get => _UserName; set => _UserName = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string Email { get => _Email; set => _Email = value; }
        public int RoleID { get => _RoleID; set => _RoleID = value; }
        public string Image { get => _Image; set => _Image = value; }

        public LoginUser() { }
        public LoginUser(User user)
        {
            _UserName = user.UserName;
            _FirstName = user.FirstName;
            _LastName = user.LastName;
            _Email = user.Email;
            _RoleID = user.RoleID.GetValueOrDefault();
            _Image = user.Image;
        }

        public override string ToString()
        {
            return _FirstName + " " + _LastName;
        }

        public Role getLoginRole()
        {
            return client.getSingleRole(_RoleID);
        }

        public Bitmap getImage()
        {
            if (string.IsNullOrWhiteSpace(_Image))
                return new Bitmap(_Image);
            return null;
        }
    }
}
