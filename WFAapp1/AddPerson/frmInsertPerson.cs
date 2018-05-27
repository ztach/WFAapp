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

namespace WFAapp1
{
    public partial class frmInsertPerson : Form
    {
        public frmInsertPerson()
        {
            InitializeComponent();
        }

        //Person p;

        Menu m = new Menu();

        private void BtnZapiszPerson_Click(object sender, EventArgs e)
        {
            ConnectCls myConnd = new ConnectCls(InitConnection.conPath, InitConnection.conFile);
            //myConnd.SqlInsertOsoba(txtImieNazwisko.Text,txtKodMiasto.Text, txtUlicaNr.Text, txtPesel.Text);
            string s = "select * from osoba where osobaid=1";
            var pp = myConnd.SqlReturnOneRecord(s);
            
            Person person = new Person(pp.Item1, pp.Item2, pp.Item3, pp.Item4);

            //MessageBox.Show(pp.Item1+pp.Item2+pp.Item3+pp.Item4);

            MessageBox.Show(person.ImieNazwisko + " " + person.KodMiasto + " "+ person.Telefon);


            this.Close();
        }
        
        private void BtnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmInsertPerson_Load(object sender, EventArgs e)
        {

        }
    }
}
