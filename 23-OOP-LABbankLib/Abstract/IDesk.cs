using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Abstract
{
    public interface IDesk
    {
        string Name { get; set; }
        int ProcessNumber { get; set; }
        bool Status { get; set; }
        void DoAction();
    }
}
