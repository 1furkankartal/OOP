using _23_OOP_LABbankLib.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Concrete
{
    public  class Desk : IDesk
    {
        public string Name { get; set; }
        public int ProcessNumber { get; set; }
        public bool Status { get; set; }

        public void DoAction()
        {
            //Control...
        }
    }
}
