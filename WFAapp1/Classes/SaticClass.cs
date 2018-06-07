using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAapp1.Classes
{
    public static class SaticClass
    {
        public static bool statusWejscia { get; set; }
        private static int _countMenuBase;
        public static int countMenuBase
        {
            get
            {
                return _countMenuBase;
            }
            set
            {
                _countMenuBase = value;
            }
        }


    }
}
