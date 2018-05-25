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

        Menu m = new Menu();
        private void btnOpenDataBase_Click(object sender, EventArgs e)
        {
            string query = "select * from Osoba";
            ConnectCls myConn = new ConnectCls(InitConnection.conPath, InitConnection.conFile);
            myConn.OpenConnection();
            bsOsoba.DataSource = myConn.ShowDataInGridView(query);
            dataGridView1.DataSource = bsOsoba;
            bindingNavigator1.BindingSource = bsOsoba;

            myConn.CloseConnection();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string query = "select distinct imieNazwisko || ' ' || kodMiasto || ' ' || UlicaNr as adres" +
                " from KtoCoKiedyWypozyczylView where osobaId=" + lblOsobaId.Text;
            ConnectCls myConnn = new ConnectCls(InitConnection.conPath, InitConnection.conFile);
            myConnn.OpenConnection();
            txtWynik.Text = myConnn.SqlExecuteOneValue(query);


            query = "select autor,tytul,odKiedy,DoKiedy,czas  from KtoCoKiedyWypozyczylView where osobaId=" + lblOsobaId.Text;
            
            myConnn.OpenConnection();
            bsWypozyczenia.DataSource = myConnn.ShowDataInGridView(query);
            dataGridView2.DataSource = bsWypozyczenia;
            bindingNavigator2.BindingSource = bsWypozyczenia;

            myConnn.CloseConnection();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOsobaId.Text = "1";
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                lblOsobaId.Text = row.Cells[0].Value.ToString();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            frmInsertPerson frm = new frmInsertPerson();
            frm.Show();
        }
    }
}
