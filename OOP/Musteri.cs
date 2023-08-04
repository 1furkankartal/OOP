using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Musteri
    {
        int _mId;
        string _mno;
        string _mad;
        string _msoyad;
        string _mturu;

        public int MId { get => _mId; set => _mId = value; }
        public string Mno { get => _mno; set => _mno = value; }
        public string Mad { get => _mad; set => _mad = value; }
        public string Msoyad { get => _msoyad; set => _msoyad = value; }
        public string Mturu { get => _mturu; set => _mturu = value; }
    }
}
