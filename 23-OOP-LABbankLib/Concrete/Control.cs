using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Concrete
{
    public static class Control
    {
        static int processNum = 0;
        static int say = 0;
        public static int SendNumberToDesk()
        {
           if(CustomerWaiting.waitingCustomerVIP.Count>0) 
            {
                Console.WriteLine("sırada ki numara: " + CustomerWaiting.waitingCustomerVIP[0].Number);
                processNum = CustomerWaiting.waitingCustomerVIP[0].Number;
                CustomerWaiting.waitingCustomerVIP.RemoveAt(0);
                DailyProcess.SetNumber(Enums.CustomerType.VipCustomer);
                return processNum;
            }
           else if (CustomerWaiting.waitingCustomerDesk.Count>0&&say<3)
            {
                Console.WriteLine("SIrada ki numara: " + CustomerWaiting.waitingCustomerDesk[0].Number);
                processNum = CustomerWaiting.waitingCustomerDesk[0].Number;
                CustomerWaiting.waitingCustomerDesk.RemoveAt(0);
                DailyProcess.SetNumber(Enums.CustomerType.DeskCustomer);
                say++;
                return processNum;
            }
           else if(CustomerWaiting.waitingCustomerStandart.Count>0) 
            {
                Console.WriteLine("SIrada ki numara: " + CustomerWaiting.waitingCustomerStandart[0].Number);
                processNum = CustomerWaiting.waitingCustomerStandart[0].Number;
                CustomerWaiting.waitingCustomerStandart.RemoveAt(0);
                DailyProcess.SetNumber(Enums.CustomerType.DeskCustomer);
                say = 0;
                return processNum;
            }
           else
            {
                throw new Exception("Bekleyen Müşteri Ek");
            }
        }
    }
}
