﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAapp1.Classes;

namespace WFAapp1
{
    public partial class frmInsertPerson : Form
    {
        public frmInsertPerson()
        {
            InitializeComponent();
        }

        //Person p;

        private void btnZapiszPerson_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();

          ConnectCls myConnd = new ConnectCls(f.conPath, f.conFile);
          myConnd.OpenConnection();
          string s = myConnd.sqlInsert(txtImieNazwisko.Text,txtKodMiasto.Text, txtUlicaNr.Text, txtPesel.Text);
          myConnd.SqlCommandNonQuery(s);

            this.Close();
            this.Close();
            this.Close();
        }

        private void btnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}