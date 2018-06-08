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
        PersonValidate p;

        private void BtnZapiszPerson_Click(object sender, EventArgs e)
        {
            PersonCommands myConnd = new PersonCommands(IniDataBaseFile.conPath, IniDataBaseFile.conFile);
           // myConnd.SqlInsertOsoba(txtImieNazwisko.Text,txtKodMiasto.Text, txtUlicaNr.Text, txtPesel.Text);
            string s = "select * from osoba where osobaid=1";
            var pp = myConnd.SqlReturnOneRecord(s); 

            p = new PersonValidate(pp.ImieNazwisko,pp.KodMiasto,pp.ulicaNr,pp.Telefon,pp.Email);

            //lblTelefonVal.Text = person.TelefonValidate();
            //lblEmailVal.Text = person.EmailValidate();
            
            if (PersonValidate.PersonIsOk || p.isPersonOk())
            {
                MessageBox.Show(p.ImieNazwisko + " " + p.KodMiasto + " TEL: " + p.Telefon + " EMAIL: " + p.Email);
                this.Close();
            }
            
        }
        
        private void BtnAnuluj_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

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

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {
            p = new PersonValidate(txtImieNazwisko.Text, txtKodMiasto.Text, txtUlicaNr.Text, txtTelefon.Text, txtEmail.Text);
            lblTelefonVal.Text = p.TelefonValidate();
        }

        private void lblTelefon_MouseHover(object sender, EventArgs e)
        {
            ToolTip mToolTip = new System.Windows.Forms.ToolTip();
            mToolTip.SetToolTip(this.lblTelefon, "przyjmuję nr tel. w formacie\n"+
                "xxx xx xx xx\n"+
                "xxx xx-xx-xx\n" +
                "(xxx) xx xx xx\n" +
                "(xxx) xx-xx-xx\n" +
                "xx xxx xx xx\n" +
                "xx xxx-xx-xx\n" +
                "(xx) xxx xx xx\n" +
                "(xx) xxx-xx-xx\n"
                );
        }



        private void txtImieNazwisko_TextChanged(object sender, EventArgs e)
        {
            p = new PersonValidate(txtImieNazwisko.Text, txtKodMiasto.Text, txtUlicaNr.Text, txtTelefon.Text, txtEmail.Text);
            lblINazwiskoVal.Text = p.ImieNazwiskoValidate();
        }

        private void txtUlicaNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            p = new PersonValidate(txtImieNazwisko.Text, txtKodMiasto.Text, txtUlicaNr.Text, txtTelefon.Text, txtEmail.Text);
            lblUlicaNrVal.Text = p.UlicaNrValidate();
        }
    }
}
