using System.IO;
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
                _conPath = (value.Trim().IndexOf(@"\", value.Trim().Length - 1) == -1 ? value + @"\" : value);
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

        public static string getIniFile(string myFile,string iniPath)
        {
            IniFile MyIni = new IniFile(iniPath);

            if (!MyIni.KeyExists("myConFile", "CONNECT"))
            {
                MyIni.Write("myConFile", myFile, "CONNECT");
            }

            conFile = MyIni.Read("myConFile", "CONNECT");

            return conFile;
        }

        public static string getIniFile(string myFile)
        {
            IniFile MyIni = new IniFile();

            MyIni.DeleteKey("myConPath", "CONNECT");
            MyIni.Write("myConFile", myFile, "CONNECT");

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

        public static string getIniPath(string myPath)
        {

            IniFile MyIni = new IniFile();

            MyIni.DeleteKey("myConPath", "CONNECT");
            MyIni.Write("myConPath", myPath, "CONNECT");

            conPath = MyIni.Read("myConPath", "CONNECT");

            return conPath;
        }

        public static string getIniPath(string myPath,string iniPath)
        {

            IniFile MyIni = new IniFile(iniPath);

            if (!MyIni.KeyExists("myConPath", "CONNECT"))
            {
                MyIni.Write("myConPath", myPath, "CONNECT");
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

        public static bool spraedzPlik(string kom)
        {
            bool jest = true;

            if (!File.Exists(IniDataBaseFile.conPath + IniDataBaseFile.conFile))
            {
                jest = false;
            }
            return jest;
        }

        public void CheckIniDataBase( MenuStrip ms, bool ft)
        {
            getIniFile();
            getIniPath();
            if (!spraedzPlik("1"))
            {
                for (int i = 0; i < SaticClass.countMenuBase; i++)
                {
                    ms.Items[i].Enabled = ft;
                }
            }
        }

    }
}
