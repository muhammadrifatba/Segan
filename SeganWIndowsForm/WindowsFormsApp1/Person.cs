using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Person
    {
        private int _userID;
        private string _email;
        private string _username;
        private string _password;
        private int _role;

        public int UserID
        {
            get { return _userID; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public int Role
        {
            get { return _role; }
            set { _role = value; }
        }

        public Boolean Login(string username, string password)
        {
            if (username == "admin" & password == "admin")
            {
                _role = 1;
                return true;
            }
            else if (username == "user" & password == "user")
            {
                _role = 2;
                return true;
            }
            else
            {
                _role = 0;
                return false;
            }
        }

        public void editUsername(string username)
        {

        }

        public void editPassword(string password)
        {

        }

        public void deleteUser(string userID)
        {

        }
    }

    class User : Person
    {
        public Boolean verifyLogin(int role)
        {
            if (role == 2) return true;
            else return false;
        }
    }

    class Admin : Person
    {
        public Boolean verifyLogin(int role)
        {
            if (role == 1) return true;
            else return false;
        }
    }
}
