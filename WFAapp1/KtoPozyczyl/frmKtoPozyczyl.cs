using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAapp1.Classes;


namespace WFAapp1
{
    public partial class Form1 : Form
    {
      
        BindingSource bsOsoba = new BindingSource();
        BindingSource bsWypozyczenia = new BindingSource();

        public Form1()
        {
            InitializeComponent();
        }


        private void BtnOpenDataBase_Click(object sender, EventArgs e)
        {
            string mquery = "select * from Osoba";
            OpenDataBase odb = new OpenDataBase
            {
                query = mquery
            };
            
            odb.BindingDataGrid(bsOsoba, dataGridView1, bindingNavigator1);
            dataGridView1.Columns["OsobaId"].Visible = false;
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //
            // pobieram informacje o osobie
            //
            string mquery = "select distinct imieNazwisko || ' ' || kodMiasto || ' ' || UlicaNr as adres" +
                " from osoba where osobaId=" + lblOsobaId.Text;

            ConnectCls myConnn = new ConnectCls(InitConnection.conPath, InitConnection.conFile);
            
            txtWynik.Text = myConnn.SqlExecuteOneValue(mquery);

            //
            // pobieram informacje o wypożyczonych książkach osoby j.w.
            //
            mquery = "select autor,tytul,odKiedy,DoKiedy,czas  from KtoCoKiedyWypozyczylView where osobaId=" + lblOsobaId.Text;

            OpenDataBase odb = new OpenDataBase
            {
                query = mquery
            };
            odb.BindingDataGrid(bsWypozyczenia, dataGridView2, bindingNavigator2);
            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOsobaId.Text = "1";
        }

        

        private void ReturnOsobaId(DataGridViewCellEventArgs ez)
        {
            if (ez.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[ez.RowIndex];
                lblOsobaId.Text = row.Cells[0].Value.ToString();
            }

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReturnOsobaId(e);
        }

        private void BindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //bindingNavigatorDeleteItem.Visible = false;
            if (!this.IsDisposed)
            {
                this.Close();
            }

            frmInsertPerson frm = new frmInsertPerson();
            frm.Show();
                
        }
 

        private void BindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            lblOsobaId.Text = row.Cells[0].Value.ToString();
        }

        private void BindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex];
            lblOsobaId.Text = row.Cells[0].Value.ToString();
        }

        private void bindingNavigatorUpdateItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Button1_Click(sender,e);
        }
    }
}
