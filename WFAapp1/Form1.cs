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
        private DataTable myTable;

        public Form1()
        {
            InitializeComponent();
        }

        BindingSource bs = new BindingSource();
        

        private void btnOpenDataBase_Click(object sender, EventArgs e)
        {
            /*
                        Person osoba = new Person();
                        osoba.ImieNazwisko  ="";//this.imieNazwiskoTextBox.Text;
                        osoba.KodMiasto     ="";//this.kodMiastoTextBox.Text;
                        osoba.ulicaNr       ="";//this.ulicaNrTextBox.Text;
                        osoba.Pesel         = "";//this.pESELTextBox.Text;

                        string query = "INSERT INTO Osoba(ImieNazwisko, KodMiasto," +
                            "ulicaNr,PESEL ) VALUES ('"
                        + osoba.ImieNazwisko + "','" +
                        osoba.KodMiasto + "','" + osoba.ulicaNr + "','" +
                        osoba.Pesel + "')";
            */


            string query = "select * from Osoba";

            string StringConn = @"Data Source=F:\praca\WFAapp\WFAapp1\Baza\Ksiazki.s3db;";

            SQLiteConnection sql_con = new SQLiteConnection(StringConn);
            sql_con.Open();

            SQLiteDataAdapter myAdapter = new SQLiteDataAdapter(query, sql_con);
            DataSet myDataSet = new DataSet();
            DataTable myTable = new DataTable();
            myTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
            myAdapter.Fill(myDataSet);
            myTable = myDataSet.Tables[0];

            bs.DataSource = myTable;
           
            dataGridView1.DataSource = bs;
            bindingNavigator1.BindingSource = bs;


     
            //lblOsobaId.Text = "1";

            sql_con.Close();

        }
/*
        void bs_PositionChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = myTable[bs.Position];
        }
        */

        private void button1_Click(object sender, EventArgs e)
        {
            //SQLiteConnection.CreateFile(@"F:\praca\WFAapp\WFAapp1\Baza\MyDatabase.sqlite");
            SQLiteConnection m_dbConnection;
            m_dbConnection = new SQLiteConnection(@"Data Source=F:\praca\WFAapp\WFAapp1\Baza\MyDatabase.sqlite;Version=3;");
           // @"Data Source=F:\praca\WFAapp\WFAapp1\Baza\Ksiazki.s3db;";
            m_dbConnection.Open();
            /* string sql = "create table highscores (name varchar(20), score int)";
             SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
             command.ExecuteNonQuery();
             sql = "insert into highscores (name, score) values ('Me', 3000)";
             command = new SQLiteCommand(sql, m_dbConnection);

             command.ExecuteNonQuery();
             sql = "insert into highscores (name, score) values ('Myself', 6000)";
             command = new SQLiteCommand(sql, m_dbConnection);
             command.ExecuteNonQuery();
             sql = "insert into highscores (name, score) values ('And I', 9001)";
             command = new SQLiteCommand(sql, m_dbConnection);
             command.ExecuteNonQuery();
             */
            string sql = "select * from highscores order by score desc";
            SQLiteCommand command = new SQLiteCommand(sql, m_dbConnection);
            
            command = new SQLiteCommand(sql, m_dbConnection);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                txtWynik.Text += "Name: " + reader["name"] + "\tScore: " + reader["score"]+"\n";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*
            bs.DataSource = typeof(Person);
            bs.Add(new Person(7,"ab","cd","ef","55"));
            dataGridView1.DataSource = bs;
            dataGridView1.AutoGenerateColumns = true;
            //dataGridView1.DataMember
            txtWynik.DataBindings.Add("Text", bs, "Model");
            */
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                lblOsobaId.Text = row.Cells[0].Value.ToString();
            }
        }
    }
}
