using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SQLite;
using System.Data;

namespace WFAapp1.Classes
{
    public class ConnectCls
    {

        private static string StringConn;
        public ConnectCls(string conPath, string conFile)
        {
            StringConn = @"Data Source=" + conPath + conFile + ";";
        }

        SQLiteConnection sql_con;
        SQLiteDataAdapter adapter;
        SQLiteCommand sqlCommandmd;

        public void OpenConnection()
        {
            sql_con = new SQLiteConnection(StringConn);
            sql_con.Open();
        }

        public void CloseConnection()
        {
            sql_con.Close();
        }

        public void SqlCommandNonQuery(string sql)
        {
            OpenConnection();
            sqlCommandmd = new SQLiteCommand(sql)
            {
                Connection = sql_con
            };

            try
            {
                sqlCommandmd.ExecuteNonQuery();
            }
            finally
            {
                CloseConnection();
            }
        }

        public string SqlExecuteOneValue(string sql)
        {
            OpenConnection();
            sqlCommandmd = new SQLiteCommand(sql)
            {
                Connection = sql_con
            };

            try
            {
                object result = sqlCommandmd.ExecuteScalar();
                return (result == null ? "" : result.ToString());
            }
            finally
            {
                CloseConnection();
            }
        }

        public (string, string, string, string) SqlReturnOneRecord(string sql)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            sqlCommandmd = new SQLiteCommand(sql)
            {
                Connection = sql_con
            };

            try
            {
                SQLiteDataReader dr = sqlCommandmd.ExecuteReader();
                dt.Load(dr);
                DataRow row = dt.Rows[0];
                return (Convert.ToString(row[1]), Convert.ToString(row[2]), Convert.ToString(row[3]), Convert.ToString(row[4]));
            }
            finally
            {
                CloseConnection();
            }
        }


        public object ShowDataInGridView(string sql)
        {
            adapter = new SQLiteDataAdapter(sql, StringConn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }

        public void SqlInsertOsoba(string v1, string v2, string v3, string v4)
        {
            string s = "INSERT INTO Osoba(ImieNazwisko, KodMiasto," +
               "ulicaNr,Telefon ) VALUES ('"+ v1 + "','" + v2 + "','" + v3 + "','" + v4 + "')";
            SqlCommandNonQuery(s);
        }

        public void SqlUpdateOsoba(string v1, string v2, string v3, string v4,int i1)
        {
            string s = "Update Osoba" +
                " set ImieNazwisko=" + v1 +
                ", " +
                "KodMiasto=" + v2 +
                "," +
               "ulicaNr" + v3 +
               "," +
               "Telefon" + v4 +
               "where OsobaId=" + i1;
            SqlCommandNonQuery(s);
        }

    }
}
