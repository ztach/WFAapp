using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAapp1.Classes;

namespace WFAapp1.Dostep
{
    public partial class frmDostep : Form
    {
        public frmDostep()
        {
            InitializeComponent();
        }
        /*public static string myFileName { get; set; }
        public static string myPath { get; set; }*/


        private void frmDostep_Load(object sender, EventArgs e)
        {
            txtNazwaPliku.Text = "Ksiazki.s3db";
            txtSciezkaDostepu.Text = Path.GetDirectoryName(Application.ExecutablePath);
            txtSciezkaDoIni.Text = Path.GetDirectoryName(Application.ExecutablePath) + @"\";
        }

        private void btnZaloguj_Click(object sender, EventArgs e)
        {
            IniDataBaseFile.getIniFile(txtNazwaPliku.Text);
            IniDataBaseFile.getIniPath(txtSciezkaDostepu.Text);
            this.Close();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Menu górne

        private void tslblZnajdzPlikBazy_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Data base Files (*.s3db)|*.s3db|Data base old (*.sqlite)|*.sqlite|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string p = openFileDialog.FileName;
                txtNazwaPliku.Text = Path.GetFileName(p);
                txtSciezkaDostepu.Text = Path.GetDirectoryName(p) + "\\";
            }
        }

        private void tslblZnajdzPlikIni_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Data base Files (*.ini)|*.ini|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string p = openFileDialog.FileName;
                txtSciezkaDoIni.Text = p;
            }
        }

        private void tslblZnajdzPlikBazy_MouseHover(object sender, EventArgs e)
        {
            tslblZnajdzPlikBazy.BackColor = Color.FromArgb(250,250,1);
            tslblZnajdzPlikBazy.ForeColor = Color.FromArgb(1,1,1);
        }

        private void tslblZnajdzPlikIni_MouseHover(object sender, EventArgs e)
        {
            tslblZnajdzPlikIni.BackColor = Color.FromArgb(250, 250, 1);
            tslblZnajdzPlikIni.ForeColor = Color.FromArgb(1, 1, 1);
        }


        private void tslblZnajdzPlikBazy_MouseLeave(object sender, EventArgs e)
        {
            tslblZnajdzPlikBazy.BackColor = Color.FromArgb(4, 26, 138);
            tslblZnajdzPlikBazy.ForeColor = SystemColors.ButtonHighlight;
        }

        private void tslblZnajdzPlikIni_MouseLeave(object sender, EventArgs e)
        {
            tslblZnajdzPlikIni.BackColor = Color.FromArgb(4, 26, 138);
            tslblZnajdzPlikIni.ForeColor = SystemColors.ButtonHighlight;
        }

        #endregion

    }
}
