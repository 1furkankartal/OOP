using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_OOP_InterfaceLAB
{
    internal class Defans : IFutbolcu
    {
        private byte _sutGucu;
        public string AdiSoyadi { get ; set ; }
        public string FormaNo { get ; set ; }
        public byte Sutgucu {
            get { return _sutGucu; }
            set 
            {
                if (value > 70)
                {
                    Console.WriteLine("Defans oyuncusunun gücü 70 den fazla olamaz");
                }
                else
                {
                    _sutGucu = this.Sutgucu;
                }
            }
        }
        public byte Refleks { get ; set ; }
        public byte Hiz { get ; set ; }
        public byte Agresiflik { get ; set ; }
        public bool Formdami { get ; set ; }

        public void Pasver()
        {
            Console.WriteLine("");
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
