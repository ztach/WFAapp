using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFAapp1.Classes;

namespace WFAapp1.Classes
{
    public class OpenDataBase 
    {
        string _query;
        public string query
        {
            get
            {
                return _query;
            }
            set
            {
                _query = value;
            }
        }

        public void BindingDataGrid(BindingSource bs,DataGridView dg,BindingNavigator bn)
        {
            ConnectCls myConn = new ConnectCls(InitConnection.conPath, InitConnection.conFile);
            myConn.OpenConnection();
            bs.DataSource = myConn.ShowDataInGridView(query);
            dg.DataSource = bs;
            bn.BindingSource = bs;

            myConn.CloseConnection();
        }

    }
}
