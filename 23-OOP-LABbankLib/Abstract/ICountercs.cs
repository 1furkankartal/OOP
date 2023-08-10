using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Abstract
{
    public interface ICountercs
    {
        int VipCustomerCount { get; set; }
        int StandartCustomerCount { get; set; }
        int DeskCustomerCount { get; set; }
    }
}
