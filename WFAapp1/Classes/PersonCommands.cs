using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAapp1.Classes
{
    class PersonCommands : SQLiteCommands
    {
        public PersonCommands(string conPath, string conFile)
            : base(conPath, conFile)
        {
        }

        public void SqlInsertOsoba(string v1, string v2, string v3, string v4)
        {
            string s = "INSERT INTO Osoba(ImieNazwisko, KodMiasto," +
               "ulicaNr,Telefon ) VALUES ('" + v1 + "','" + v2 + "','" + v3 + "','" + v4 + "')";
            SqlCommandNonQuery(s);
        }

        public void SqlUpdateOsoba(string v1, string v2, string v3, string v4, int i1)
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
