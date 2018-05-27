using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAapp1.Classes
{
    class Person
    {
        private int    _OsobaId;
        private string _ImieNazwisko;
        private string _KodMiasto;
        private string _ulicaNr;
        private string _Telefon;

        public int OsobaId
        {
            get
            {
                return _OsobaId;
            }
            set
            {
                _OsobaId = value;
            }
        }

        public string ImieNazwisko
        {
            get
            {
                return _ImieNazwisko;
            }
            set
            {
                _ImieNazwisko = value;
            }
        }

        public string KodMiasto
        {
            get
            {
                return _KodMiasto;
            }
            set
            {
                _KodMiasto = value;
            }
        }
        public string ulicaNr
        {
            get
            {
                return _ulicaNr;
            }
            set
            {
                _ulicaNr = value;
            }
        }

        public string Telefon
        {
            get
            {
                return _Telefon;
            }
            set
            {
                _Telefon = value;
            }
        }

        public (int, string, string, string, string) ShowPerson()
        {
            return (this.OsobaId, this.ImieNazwisko, this.KodMiasto, this.ulicaNr, this.Telefon);
        }

        public (string, string, string, string) ShowPersonVal()
        {
            return (this.ImieNazwisko, this.KodMiasto, this.ulicaNr, this.Telefon);
        }


        public Person(int v1, string v2, string v3, string v4, string v5)
        {
            this._OsobaId = v1;
            this._ImieNazwisko = v2;
            this._KodMiasto = v3;
            this._ulicaNr = v4;
            this._Telefon = v5;
        }

        public Person(string v2, string v3, string v4, string v5)
        {
            this._ImieNazwisko = v2;
            this._KodMiasto = v3;
            this._ulicaNr = v4;
            this._Telefon = v5;
        }

        public Person()
        {
        }

    }
}
