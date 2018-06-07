using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAapp1.Classes
{
    class LoginValidate:Login
    {
        public LoginValidate(string user, string pass) :
            base(user,pass)
        {
        }
        public string userMessage { get; set; }
        public string passMessage { get; set; }

        //validate string 
        private bool StringValidator(string input)
        {
            string pattern = "[^a-zA-Z0-9@#$%!&]+";
            if (Regex.IsMatch(input, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //clear user inputs 
        private void ClearTexts(string user, string pass)
        {
            user = String.Empty;
            pass = String.Empty;
        }

        //method to check if eligible to be logged in 
        public bool UserValidate(string user)
        {

            if (string.IsNullOrEmpty(user))
            {
                userMessage = "Enter the user name!";
                return false;
            }
            //check user name is valid type 
            if (StringValidator(user) == true)
            {
                userMessage = "Enter only text here";
                return false;
            }
            //check user name is correct 
            if (Username != user)
                {
                    userMessage = "User name is incorrect!";
                    return false;
                }

            userMessage = "User name is correct!";
            return true;
        }

        public bool PasswordValidate(string pass)
        {
            if (string.IsNullOrEmpty(pass))
            {
                passMessage = "Enter the passowrd!";
                return false;
            }
            //check password is valid 
            if (StringValidator(pass) == true)
            {
                passMessage = "Enter only integer here";
                return false;
            }
            //check password is correct 
            if (Password != pass)
            {
                passMessage = "Password is incorrect!";
                return false;
            }

            passMessage = "Password is correct";
            return true;
        }


        public bool IsLoggedIn(string user, string pass)
        {

            bool u = UserValidate(user);
            bool p = PasswordValidate(pass);

            return u && p;
            

    }
}
}
