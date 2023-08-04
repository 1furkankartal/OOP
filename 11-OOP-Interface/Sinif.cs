using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_OOP_Interface
{
    internal class Sinif : IBicim1
    {
        private int _numaram;
        public int Numaram {
            get { return _numaram; }
            set { _numaram = this.Numaram; }
        }
        public int Numaran { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void InterfaceMetod()
        {

        }
    }
}
