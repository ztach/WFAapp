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


        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            //define local variables from the user inputs 
            LoginValidate.statusWejscia = false;
            string user = txtLogin.Text;
            string pass = txtHaslo.Text;
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
    }

}
