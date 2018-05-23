using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAapp1.Classes
{
    class Person
    {
        public int OsobaId;
        public string ImieNazwisko;
        public string KodMiasto;
        public string ulicaNr;
        public string Pesel;
        public Person(int v1, string v2, string v3, string v4, string v5)
        {
            this.OsobaId = v1;
            this.ImieNazwisko = v2;
            this.KodMiasto = v3;
            this.ulicaNr = v4;
            this.Pesel = v5;
        }
    }
}
