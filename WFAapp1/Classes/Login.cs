using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAapp1.Classes
{
    class Login
    {
        //decalre properties 
        private string _Username;
        private string _Password;

        public string Username
        {
            get
            {
                return _Username;
            }
            set
            {
                _Username = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
            }
        }

        //initialise  
        public Login(string user, string pass)
        {
            this.Username = user;
            this.Password = pass;
        }

    }
}
