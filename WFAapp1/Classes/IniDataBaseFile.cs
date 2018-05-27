﻿using System.IO;
using System.Windows.Forms;

namespace WFAapp1.Classes
{
    public class IniDataBaseFile
    {
        static string _conPath;
        static string _conFile;

        public static string conPath
        {
            get
            {
                return _conPath;
            }
            set
            {
                _conPath = value;
            }
        }


        public static string conFile
        {
            get
            {
                return _conFile;
            }
            set
            {
                _conFile = value;
            }
        }

        
        public static string getIniFile() {
            IniFile MyIni = new IniFile();

            if (!MyIni.KeyExists("myConFile", "CONNECT"))
            {
                MyIni.Write("myConFile", @"Ksiazki.s3db", "CONNECT");
            }

            conFile = MyIni.Read("myConFile", "CONNECT");

            return conFile;
        }


        public static string getIniPath()
        {

            IniFile MyIni = new IniFile();

            if (!MyIni.KeyExists("myConPath", "CONNECT"))
            {
                MyIni.Write("myConPath", @"f:\praca\WFAapp\WFAapp1\Baza\", "CONNECT");
            }

            conPath = MyIni.Read("myConPath", "CONNECT");

            return conPath;
        }

        public static bool spraedzPlik()
        {
            bool jest = true;

            if (!File.Exists(IniDataBaseFile.conPath + IniDataBaseFile.conFile))
            {
                MessageBox.Show(
                    " podana ścieżka: " + IniDataBaseFile.conPath + " jest niepawidłowa!!!\n" +
                    "                 lub\n" +
                    " podany plik: " + IniDataBaseFile.conFile + " jest nieprawidlowy !!!!" +
                    "\n\n" +
                    "puszukaj pliku .ini i zmień dostęp!!!" +
                    "\n\n" +
                    "           szczegóły opisałem w pomocy (Help)"
                    );
                jest = false;
            }

            return jest;

        }
    }
}