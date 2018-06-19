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
    public partial class frmKtoPozyczyl : Form
    {
      
        BindingSource bsOsoba = new BindingSource();
        BindingSource bsWypozyczenia = new BindingSource();

        public frmKtoPozyczyl()
        {
            InitializeComponent();
        }

        #region BUTTONY

        private void BtnOpenDataBase_Click(object sender, EventArgs e)
        {
            string mquery = "select * from Osoba";
            OpenBindingDataBase(bsOsoba, dataGridView1, bindingNavigator1,mquery);
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

            SQLiteCommands myConnn = new SQLiteCommands(IniDataBaseFile.conPath, IniDataBaseFile.conFile);

            txtWynik.Text = myConnn.SqlReturnOneValue(mquery);
            

            string query = "select ksiazkiId from pierwszePozyczenie where osobaId = " + lblOsobaId.Text;


            lblKsiazkaId.Text = myConnn.SqlReturnOneValue(query);
            lblKsiazkaOsobaId.Text = lblOsobaId.Text;
            wypelnijGrid2(lblOsobaId.Text);
 
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOsobaId.Text = "1";
           // bindingNavigator1.Items[0].Visible = true;
        }



        #region POMOCNICZE DO ID

        private void OpenBindingDataBase(BindingSource bs, DataGridView dg, BindingNavigator bn, string sql)
        {
            OpenDataBase odb = new OpenDataBase
            {
                query = sql
            };

            odb.BindingDataGrid(bs, dg, bn);
        }

        private void ReturnOsobaId(DataGridViewCellEventArgs ez)
        {

            if (ez.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[ez.RowIndex];
                lblOsobaId.Text = row.Cells[0].Value.ToString();
            }
        }

        private void ReturnOsobaKsiazkaId(DataGridViewCellEventArgs ez)
        {

            if (ez.RowIndex >= 0)
            {
                DataGridViewRow rowz = this.dataGridView2.Rows[ez.RowIndex];
                lblKsiazkaOsobaId.Text = rowz.Cells[6].Value.ToString();
                lblKsiazkaId.Text = rowz.Cells[7].Value.ToString();
            }
        }

        private void wypelnijGrid2(string i)
        {
            //
            // pobieram informacje o wypożyczonych książkach osoby j.w.
            // 
            string mquery = "select *  from KtoCoKiedyWypozyczylView where osobaId=" + i;

            OpenBindingDataBase(bsWypozyczenia, dataGridView2, bindingNavigator2, mquery);
            dataGridView2.Columns["wypozyczajacy"].Visible = false;
            dataGridView2.Columns["OsobaId"].Visible = false;
            dataGridView2.Columns["KsiazkiId"].Visible = false;
            dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        #endregion


        #region MENU

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

        #endregion

        #region GRID 1

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReturnOsobaId(e);
        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Button1_Click(sender,e);
        }

        #endregion


        #region GRID 2

        private void dataGridView2_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ReturnOsobaKsiazkaId(e);
        }

        #endregion
    }
}
