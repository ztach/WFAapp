using System;
using System.Data.SQLite;
using System.Data;

namespace WFAapp1.Classes
{
    class SQLiteCommands : ConnectCls
    {
        public SQLiteCommands(string conPath, string conFile)
            : base(conPath, conFile)
        {
        }

        SQLiteCommand sqlCommandmd;

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

        public Person SqlReturnOneRecord(string sql)
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
                Person p = new Person(Convert.ToString(row[1]), Convert.ToString(row[2]), Convert.ToString(row[3]), Convert.ToString(row[4]), Convert.ToString(row[5]));
                return p;
            }
            finally
            {
                CloseConnection();
            }
        }


        SQLiteDataAdapter adapter;
        public object ShowDataInGridView(string sql)
        {
            adapter = new SQLiteDataAdapter(sql, StringConn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            object dataum = ds.Tables[0];
            return dataum;
        }


    }
}
