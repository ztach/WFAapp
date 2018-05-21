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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenDataBase_Click(object sender, EventArgs e)
        {
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

            string StringConn = @"Data Source=F:\praca\WFAapp\WFAapp1\Baza\Ksiazki.s3db;";

            

            SQLiteConnection sql_con = new SQLiteConnection(StringConn);
            SQLiteDataAdapter myAdapter = new SQLiteDataAdapter(query, sql_con);
            myAdapter.MissingSchemaAction = MissingSchemaAction.AddWithKey;

            DataSet myDataSet = new DataSet();
            myAdapter.Fill(myDataSet, "Persons");
            //myDataSet.Tables["Person"].
            //object[] rowVals = new object[2];
            string wektor = "";

            foreach(DataTable myTable in myDataSet.Tables)
            {
                foreach(DataRow myRow in myTable.Rows)
                {
                    foreach(DataColumn myColumn in myTable.Columns)
                    {
                        wektor += myRow[myColumn];
                        /*List<Person> person = new List<Person>
                        {
                            new Person(myRow[myColumn].ToString());

                        };*/
                    }
                }
            }

            /*
            SQLiteCommand sql_cmd = new SQLiteCommand(query)
            {
                Connection = sql_con
            };

            sql_con.Open();


            try
            {
                //sql_cmd.ExecuteReader(CommandBehavior)
            }
            finally
            {
                sql_con.Close();
            }
            */
        }
    }
}
