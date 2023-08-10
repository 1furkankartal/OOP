using _23_OOP_LABbankLib.Abstract;
using _23_OOP_LABbankLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Concrete
{
    public class Customer : ICustomer
    {
        public Customer(string customerId, string customerName, CustomerType customerType)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            CustomerType = customerType;
            //Number = number;
        }

        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public CustomerType CustomerType { get; set; }
        public int Number { get; set; }

        public void GetNumber()
        {
            //Numarator den numara alınacak...
            Number ) Numerator.CreateNumber(CustomerType);
        }
    }
}
