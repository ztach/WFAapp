using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAapp1.Classes;
using WFAapp1.Properties;

namespace WFAapp1.LoginAdmin
{
    public partial class frmLoginAdmin : Form
    {
        public frmLoginAdmin()
        {
            InitializeComponent();
        }

        LoginValidate login = new LoginValidate("admin", "1234");

        private string user = "";
        private string pass = "";

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            LoginValidate.statusWejscia = false;
            //check if eligible to be logged in 
            if (login.IsLoggedIn(user, pass))
            {
                lblLoginValidate.Text = login.userMessage;
                lblPassValidate.Text = login.passMessage;
                LoginValidate.statusWejscia = true;
                this.Close();
            }
            else
            {
                //show default login error message 
                lblLoginValidate.Text = login.userMessage;
                lblPassValidate.Text = login.passMessage;
            }

        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private char getChar(KeyEventArgs e)
        {
            int keyValue = e.KeyValue;
            if (!e.Shift && keyValue >= (int)Keys.A && keyValue <= (int)Keys.Z)
                return (char)(keyValue + 32);
            return (char)keyValue;
        }

        string pattern = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private void txtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            string myPatt = "";
            myPatt = pattern + (char)Keys.Back;

            string x = "";
            x = getChar(e).ToString();

            if (myPatt.Contains(x))
            {

                if (e.KeyValue == (char)Keys.Back && user.Length > 0)
                {
                    user = user.Remove(user.Length - 1);
                }
                else
                {
                    user += x;
                }

                if (!login.UserValidate(user))
                {
                    lblLoginValidate.Text = login.userMessage;
                }
                else
                {
                    lblLoginValidate.Text = login.userMessage;
                    e.ToString();
                    txtHaslo.Focus();
                }
            }
        }

        private void txtHaslo_KeyDown(object sender, KeyEventArgs e)
        {
            string myPatt = "";
            myPatt = pattern + (char)Keys.Back;

            string x = "";
            x = getChar(e).ToString();
            

            int i = (int)e.KeyCode;

            //MessageBox.Show(i.ToString());

            if (myPatt.Contains(x))
            {

                if (e.KeyValue == (char)Keys.Back && pass.Length > 0)
                {
                    pass = pass.Remove(pass.Length - 1);
                }
                else
                {
                    pass += x;
                }

                if (!login.PasswordValidate(pass))
                {
                    lblPassValidate.Text = login.passMessage;
                }
                else
                {
                    lblPassValidate.Text = login.passMessage;
                    btnZaloguj.Focus();
                }
            }
        }

        private void frmLoginAdmin_Load(object sender, EventArgs e)
        {
            txtHaslo.Text = "";
            txtLogin.Text = "";
        }
    }

}
