﻿using _23_OOP_LABbankLib.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Concrete
{
    public class DailyProcess
    {
        public static int VipNumber = 0;
        public static int StandartNumber = 0;
        public static int DeskNumber = 0;

        public static List<Customer> Customers;

        public static void SetNumber(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.VipCustomer:
                    VipNumber++;
                    break;
                case CustomerType.StandartCustomer:
                    StandartNumber++;
                    break;
                case CustomerType.DeskCustomer:
                    DeskNumber++;
                    break;
                default:
                    break;  
            }
        }
    }
}
