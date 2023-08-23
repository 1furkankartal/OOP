using _23_OOP_LABbankLib.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Concrete
{
    public class CustomerDesk : BaseCustomer
    {
        public CustomerDesk(string customerId, string customerName) : base(customerId, customerName)
        {
        }

        public override void GetNumber()
        {
            Number = Numerator.CreateNumber(Enums.CustomerType.DeskCustomer,this);
        }
    }
}
