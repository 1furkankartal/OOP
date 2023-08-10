using _23_OOP_LABbankLib.Abstract;
using _23_OOP_LABbankLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Concrete
{
    public class Numerator
    {
        public static int VipNumber { get; set; } = 100;
        public static int StandartNumber { get; set; } = 300;
        public static int DeskNumber { get; set; } = 600;

        public static int CreateNumber(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.VipCustomer:
                    return ++VipNumber;
                    break;
                case CustomerType.StandartCustomer:
                    return ++StandartNumber;
                    break;
                case CustomerType.DeskCustomer:
                    return ++DeskNumber;
                    break;
                default:
                    return 0;
                    break;

            }
        }
    }
}
