using _23_OOP_LABbankLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Abstract
{
    public interface INumerator
    {
        static int VipNumber { get; set; }
        static int StandartNumber { get; set; }
        static int DeskNumber { get; set; }

        void CreateNumber(CustomerType customerType);
    }
}
