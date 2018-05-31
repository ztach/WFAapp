using System.Text.RegularExpressions;

namespace WFAapp1.Classes
{
    class PersonValidate : Person
    {

        public PersonValidate(string imieNaziwsko, string kodMiasto, string ulicaNr, string telefon, string email) :
            base(imieNaziwsko, kodMiasto, ulicaNr, telefon, email)
        {
        }

        private bool _imieNazwiskoIsOk;
        private bool _kodMiastoIsOk;
        private bool _ulicaNrIsOk;
        private bool _telefonIsOk;
        private bool _emailIsOk;

        public bool imieNazwiskoIsOk
        {
            get
            {
                return _imieNazwiskoIsOk;
            }
            set
            {
                _kodMiastoIsOk = value;
            }
        }

        public bool kodMiastoIsOk
        {
            get
            {
                return _kodMiastoIsOk;
            }
            set
            {
                _kodMiastoIsOk = value;
            }
        }

        public bool ulicaNrIsOk
        {
            get
            {
                return _ulicaNrIsOk;
            }
            set
            {
                _ulicaNrIsOk = value;
            }
        }

        public bool telefonIsOk
        {
            get
            {
                return _telefonIsOk;
            }
            set
            {
                _telefonIsOk = value;
            }
        }

        public bool emailIsOk
        {
            get
            {
                return _emailIsOk;
            }
            set
            {
                _emailIsOk = value;
            }
        }


        public string TelefonValidate()
        {
            string wynik = "ok";
            telefonIsOk = true;
            if (Telefon.Length > 11)
            {
                wynik = "źle";
                telefonIsOk = false;
            }
            return wynik;
        }

        static Regex ValidEmailRegex = CreateValidEmailRegex();
        static Regex ValidKodMiastoRegex = CreateValidKodMiastoRegex();

        private static Regex CreateValidEmailRegex()
        {
  
            string validEmailPattern = @"^((([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+(\.([a-z]|\d|[!#\$%&'\*\+\-\/=\?\^_`{\|}~]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])+)*)|((\x22)((((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(([\x01-\x08\x0b\x0c\x0e-\x1f\x7f]|\x21|[\x23-\x5b]|[\x5d-\x7e]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(\\([\x01-\x09\x0b\x0c\x0d-\x7f]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF]))))*(((\x20|\x09)*(\x0d\x0a))?(\x20|\x09)+)?(\x22)))@((([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|\d|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.)+(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])|(([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])([a-z]|\d|-|\.|_|~|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])*([a-z]|[\u00A0-\uD7FF\uF900-\uFDCF\uFDF0-\uFFEF])))\.?$";

            return new Regex(validEmailPattern, RegexOptions.IgnoreCase);
        }

        private static Regex CreateValidKodMiastoRegex()
        {

            string validKodMiastoPattern = @"\d\d-\d\d\d[ ]+\w\w*";

            return new Regex(validKodMiastoPattern, RegexOptions.IgnoreCase);
        }


        public string EmailValidate()
        {
            string wynik = "popraw adres email";
            emailIsOk = ValidEmailRegex.IsMatch(Email);
            if (emailIsOk)
            {
                wynik = "ok";
            }
            return wynik;
         }

        public string ImieNazwiskoValidate()
        {
            string wynik = "ok";
            imieNazwiskoIsOk = true;
            if (ImieNazwisko.Length < 1)
            {
                wynik = "wpisz nazwisko";
                imieNazwiskoIsOk = false;
            }
            return wynik;
        }


        public string KodMiastoValidate()
        {
            string wynik = "wpisz kod i miasto";
            kodMiastoIsOk = ValidKodMiastoRegex.IsMatch(KodMiasto);

            if (kodMiastoIsOk)
            {
                wynik = "ok";
            }
            return wynik;
        }



        public Person ShowPerson(Person p)
        {
            return p;
        }

    }
}
