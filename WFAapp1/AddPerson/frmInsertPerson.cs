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
            PersonCommands myConnd = new PersonCommands(IniDataBaseFile.conPath, IniDataBaseFile.conFile);
           // myConnd.SqlInsertOsoba(txtImieNazwisko.Text,txtKodMiasto.Text, txtUlicaNr.Text, txtPesel.Text);
           /* string s = "select * from osoba where osobaid=1";
            var pp = myConnd.SqlReturnOneRecord(s);

            PersonValidate person = new PersonValidate(pp.ImieNazwisko,pp.KodMiasto,pp.ulicaNr,pp.Telefon,pp.Email);

            lblTelefonVal.Text = person.TelefonValidate();
            lblEmailVal.Text = person.EmailValidate();
           

            MessageBox.Show(person.ImieNazwisko + " " + person.KodMiasto + " TEL: "+ person.Telefon +" EMAIL: "+  person.Email);
            */
            this.Close();
        }
        
        private void BtnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        PersonValidate p;

        private void FrmInsertPerson_Load(object sender, EventArgs e)
        {
            
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            p = new PersonValidate(txtImieNazwisko.Text, txtKodMiasto.Text, txtUlicaNr.Text, txtTelefon.Text, txtEmail.Text);
            lblEmailVal.Text = p.EmailValidate();
        }

        private void txtKodMiasto_KeyPress(object sender, KeyPressEventArgs e)
        {
            p = new PersonValidate(txtImieNazwisko.Text, txtKodMiasto.Text, txtUlicaNr.Text, txtTelefon.Text, txtEmail.Text);
            lblKodMiastoVal.Text = p.KodMiastoValidate();
        }
    }
}
