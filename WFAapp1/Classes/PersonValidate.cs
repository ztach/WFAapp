﻿using System.Text.RegularExpressions;

namespace WFAapp1.Classes
{
    class PersonValidate : Person
    {

        public PersonValidate(string imieNaziwsko, string kodMiasto, string ulicaNr, string telefon, string email) :
            base(imieNaziwsko, kodMiasto, ulicaNr, telefon, email)
        {
        }

        public static bool imieNazwiskoIsOk { get; set; }
        public static bool kodMiastoIsOk { get; set; }
        public static bool ulicaNrIsOk { get; set; }
        public static bool telefonIsOk { get; set; }
        public static bool emailIsOk { get; set; }

        public static bool PersonIsOk
        {
            get
            {
                return imieNazwiskoIsOk && kodMiastoIsOk && ulicaNrIsOk && telefonIsOk && emailIsOk;
            }
            set
            {
                PersonIsOk = imieNazwiskoIsOk && kodMiastoIsOk && ulicaNrIsOk && telefonIsOk && emailIsOk;
            }
        }
            

        /*
                private static bool _imieNazwiskoIsOk;
                private static bool _kodMiastoIsOk;
                private static bool _ulicaNrIsOk;
                private static bool _telefonIsOk;
                private static bool _emailIsOk;

                public static bool imieNazwiskoIsOk
                {
                    get
                    {
                        return _imieNazwiskoIsOk;
                    }
                    set
                    {
                        _imieNazwiskoIsOk = value;
                    }
                }

                public static bool kodMiastoIsOk
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

                public static bool ulicaNrIsOk
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

                public static bool telefonIsOk
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

                public static bool emailIsOk
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
        */

        static Regex ValidEmailRegex = CreateValidEmailRegex();
        static Regex ValidKodMiastoRegex = CreateValidKodMiastoRegex();
        static Regex ValidTelefonRegex = CreateValidTelefonRegex();
        static Regex ValidImieNazwiskoRegex = CreateValidImieNazwiskoRegex();
        static Regex ValidUlicaNrRegex = CreateValidUlicaNrRegex();


        private static Regex CreateValidUlicaNrRegex()
        {
            string validUlicaNrPattern = @"\w+ *\w*";

            return new Regex(validUlicaNrPattern, RegexOptions.IgnoreCase);
        }


        private static Regex CreateValidImieNazwiskoRegex()
        {
            string validImieNazwiskoPattern = @"\w+ *\w*";

            return new Regex(validImieNazwiskoPattern, RegexOptions.IgnoreCase);
        }
        
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

        private static Regex CreateValidTelefonRegex()
        {

            string validTelefonPattern = @"^(?(\d{3})\d{3} \d{2}(?(-)-| )\d{2}(?(-)-| )\d{2}|(?(\()\(\d{2}\d?\) \d{2}\d?(?(-)-| )\d{2}(?(-)-| )\d{2}|\d{2} \d{3}(?(-)-| )\d{2}(?(-)-| )\d{2}))$";
            //@"^(?(\d{3})\d{3}(?(-)-| )\d{2}(?(-)-| )\d{2}(?(-)-| )\d{2}|(?(\()\(\d{3}\)(?(-)-| )\d{2}(?(-)-| )\d{2}(?(-)-| )\d{2}|\d{2}(?(-)-| )\d{3}(?(-)-| )\d{2}(?(-)-| )\d{2}))$";
            //^(?(\d{3})\d{3} \d{2}(?(-)-| )\d{2}(?(-)-| )\d{2}|(?(\()\(\d{3}\) \d{2}(?(-)-| )\d{2}(?(-)-| )\d{2}|\d{2} \d{3}(?(-)-| )\d{2}(?(-)-| )\d{2}))$

            return new Regex(validTelefonPattern, RegexOptions.IgnoreCase);
        }

        
        public string UlicaNrValidate()
        {
            string wynik = "popraw nazwę ulicy lub nr";
            ulicaNrIsOk = ValidImieNazwiskoRegex.IsMatch(ImieNazwisko);
            if (ulicaNrIsOk)
            {
                wynik = "ok";
            }
            return wynik;
        }

        public string ImieNazwiskoValidate()
        {
            string wynik = "popraw imie lub nazwisko";
            imieNazwiskoIsOk = ValidImieNazwiskoRegex.IsMatch(ImieNazwisko);
            if (imieNazwiskoIsOk)
            {
                wynik = "ok";
            }
            return wynik;
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

        public string TelefonValidate()
        {
            string wynik = "nieprawidłowy numer";
            telefonIsOk = ValidTelefonRegex.IsMatch(Telefon);
            if (telefonIsOk)
            {
                wynik = "ok";
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

        public bool isPersonOk()
        {
            return imieNazwiskoIsOk && kodMiastoIsOk && ulicaNrIsOk && telefonIsOk && emailIsOk;
        }

    }
}
