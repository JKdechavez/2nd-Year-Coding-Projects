using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachPro3
{
    internal class User
    {
        private int userID;
        private string username;
        private string password;
        private string email;
        private string role;


        public User(int userID, string username, string password, string email, string role)
        {
            this.userID = userID;
            this.username = username;
            this.password = password;
            this.email = email;
            this.role = role;
        }

        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Role
        {
            get { return role; }
            set { role = value; }
        }
    }
}
