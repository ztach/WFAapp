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

        public static string StringConn;

        public ConnectCls(string conPath, string conFile)
        {
            StringConn = @"Data Source=" + conPath + conFile + ";";
        }

        protected SQLiteConnection sql_con;

        public void OpenConnection()
        {
            sql_con = new SQLiteConnection(StringConn);
            sql_con.Open();
        }

        public void CloseConnection()
        {
            sql_con.Close();
        }

    }
}
