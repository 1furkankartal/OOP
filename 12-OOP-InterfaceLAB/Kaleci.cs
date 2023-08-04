using _12_OOP_InterfaceLAB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_InterfaceLAB
{
    internal class Kaleci : IFutbolcu, IKaleci
    {
        public string KurtarmaGucu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string AdiSoyadi { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FormaNo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte Sutgucu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte Refleks { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte Hiz { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public byte Agresiflik { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Formdami { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Pasver()
        {
            throw new NotImplementedException();
        }

        public void Sutcek()
        {
            throw new NotImplementedException();
        }

        public void TopKurtar()
        {
            throw new NotImplementedException();
        }
    }
}