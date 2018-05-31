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

namespace WFAapp1.ListaKsiazek
{
    public partial class frmListaKsiazek : Form
    {
        public frmListaKsiazek()
        {
            InitializeComponent();
        }

        BindingSource bsKsiazka = new BindingSource();

        private void frmListaKsiazek_Load(object sender, EventArgs e)
        {
            string mquery = "select ksiazkiId,author,title,dataZakupu,cenaZakupu, ksiegarnia from Ksiazka";
            OpenDataBase odb = new OpenDataBase
            {
                query = mquery
            };

            odb.BindingDataGrid(bsKsiazka, dataGridView1, bindingNavigator1);
            dataGridView1.Columns["KsiazkiId"].Visible = false;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        }
    }
}
