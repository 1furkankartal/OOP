using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OOP_InterfaceLAB
{
    internal interface IFutbolcu
    {
        string AdiSoyadi { get; set; }
        string FormaNo { get; set; }

        byte Sutgucu { get; set; }
        byte Refleks { get; set; }
        byte Hiz { get; set; }
        byte Agresiflik { get; set; }
        bool Formdami { get; set; }

        void Sutcek();
        void Pasver();
       

    }
}
