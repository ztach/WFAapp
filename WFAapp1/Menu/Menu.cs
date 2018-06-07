using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAapp1.Classes;
using WFAapp1.Dostep;
using WFAapp1.Help;
using WFAapp1.ListaKsiazek;
using WFAapp1.LoginAdmin;


namespace WFAapp1
{
    public partial class Menu : Form
    {
        private int childFormNumber = 0;
        IniDataBaseFile idbf = new IniDataBaseFile();

        public Menu()
        {
            InitializeComponent();
        }

        #region Menu systemowe

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }



        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        #endregion

        private void ksiegarniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKtoPozyczyl f = new frmKtoPozyczyl();
            f.MdiParent = this;
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOProgramie f = new frmOProgramie();
            f.MdiParent = this;
            f.Show();
        }

        private void gdzieJestBazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmGdzieJestBaza1 f = new frmGdzieJestBaza1();
            f.Show();*/
            panelHelp.Visible = !panelHelp.Visible;
        }

        private void wprowadzOsobeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInsertPerson f = new frmInsertPerson();
            f.MdiParent = this;
            f.Show();
        }

        private void WprowadzKsiazkeTSMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void zarzadzajWypozyczeniamiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void Menu_Load(object sender, EventArgs e)
        {
            SaticClass.countMenuBase = 2;

            idbf.CheckIniDataBase( menuStrip,false);

            panelHelp.Visible = false;

            this.WindowState = FormWindowState.Maximized;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExitX_Click(object sender, EventArgs e)
        {
            panelHelp.Visible = false;
        }

        private void listaKsiazekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListaKsiazek lk = new frmListaKsiazek();
            lk.MdiParent = this;

            lk.Show();

        }

 
        private void WczytajInnaBazeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("wczytaj nowe");
        }

        private void adminToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            if (!SaticClass.statusWejscia)
            {
                frmLoginAdmin la = new frmLoginAdmin();
                la.ShowDialog();
                string wyszlo = la.ToString();
            }

        }

        private void dostepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDostep fd = new frmDostep();
            fd.MdiParent = this;
            fd.Show();

            idbf.CheckIniDataBase(menuStrip, true);
        }

        private void bazaToolStripMenuItem_DropDownOpened(object sender, EventArgs e)
        {
            idbf.CheckIniDataBase(menuStrip,false);
        }

        private void listaCzytelnikowToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaWypozyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
