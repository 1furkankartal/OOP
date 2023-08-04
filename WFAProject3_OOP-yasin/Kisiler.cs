using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAProject3_OOP
{
    public class Kisiler
    {
        public string _isim { get; set; }
        public string _telefon { get; set; }
        public int _yas { get; set; }
        public string _adres { get; set; }

        public override string ToString()
        {
                return _isim;
        }
    }
}
