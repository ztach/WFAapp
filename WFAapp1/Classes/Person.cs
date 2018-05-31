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
        private string _Email;

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

        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
            }
        }


        public Person(int osobaId, string imieNaziwsko, string kodMiasto, string ulicaNr, string telefon, string email)
        {
            this._OsobaId       = osobaId;
            this._ImieNazwisko  = imieNaziwsko;
            this._KodMiasto     = kodMiasto;
            this._ulicaNr       = ulicaNr;
            this._Telefon       = telefon;
            this._Email         = email;
        }

        public Person(string imieNaziwsko, string kodMiasto, string ulicaNr, string telefon, string email)
        {
            this._ImieNazwisko = imieNaziwsko;
            this._KodMiasto = kodMiasto;
            this._ulicaNr = ulicaNr;
            this._Telefon = telefon;
            this._Email = email;
        }

        public Person()
        {
        }

    }
}
