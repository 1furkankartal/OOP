using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Personal
    {
        int _personalId;
        string _sicilno;
        string _ad;
        string _soyad;

        public string Sicilno { get => _sicilno; set => _sicilno = value; }
        public int PersonalId { get => _personalId; set => _personalId = value; }
        public string Ad { get => _ad; set => _ad = value; }
        public string Soyad { get => _soyad; set => _soyad = value; }
    }

}

