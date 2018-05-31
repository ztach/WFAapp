using System.Data.SQLite;

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
