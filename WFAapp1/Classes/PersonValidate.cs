using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAapp1.Classes
{
    class PersonValidate:Person
    {
        public string TelefonValidate()
        {
            if (Telefon.Length > 11)
            {
                return "zle";
            }
            return "ok";
        }
    }
}
