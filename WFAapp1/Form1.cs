using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
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


        private void btnOpenDataBase_Click(object sender, EventArgs e)
        {
            string query = "select * from Osoba";
            ConnectCls myConn = new ConnectCls();
            myConn.OpenConnection();
            bsOsoba.DataSource = myConn.ShowDataInGridView(query);
            dataGridView1.DataSource = bsOsoba;
            bindingNavigator1.BindingSource = bsOsoba;

            myConn.CloseConnection();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "select imieNazwisko+' ' + kodMiasto +' ' + UlicaNr as adres,"+
                "autor,tytul,odKiedy,DoKiedy,czas  from KtoCoKiedyWypozyczylView where osobaId=" + lblOsobaId.Text;
            ConnectCls myConnn = new ConnectCls();
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
          
          //  MessageBox.Show (p.ImieNazwisko);

            
        }
    }
}
