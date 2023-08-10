using _23_OOP_LABbankLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Abstract
{
    public interface ICustomer
    {
        string CustomerId { get; set; }
        string CustomerName { get; set; }
        CustomerType CustomerType { get; set; }
        void GetNumber();
      

    }
}
