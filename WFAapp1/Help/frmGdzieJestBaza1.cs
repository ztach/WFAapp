using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAapp1.Help
{
    public partial class frmGdzieJestBaza1 : Form
    {
        public frmGdzieJestBaza1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void frmGdzieJestBaza1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "baza książek nazywa się" + 
               "\r\n" +
               "                            Ksiazki.s3db" +
               "\r\n" +
               "Znajdź plik: WFAapp1.ini - w odpowiednie miejsce wpisz\r\n" +
               "pełną ścieżkę dostępu do pliku bazy\r\n" +
               "";
        }
    }
}
