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
using WFAapp1.Help;
using WFAapp1.ListaKsiazek;

namespace WFAapp1
{
    public partial class Menu : Form
    {
        private int childFormNumber = 0;
//        public static string conPath;
//        public static string conFile;

        public Menu()
        {
            InitializeComponent();
        }

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

        private void ksiegarniaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.MdiParent = this;
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
            IniDataBaseFile.getIniFile();
            IniDataBaseFile.getIniPath();
            if (!IniDataBaseFile.spraedzPlik())
            {
                Application.Exit();
            }
            panelHelp.Visible = false;
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

        private void listaCzytelnikówToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaWypożyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
