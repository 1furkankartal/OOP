using _23_OOP_LABbankLib.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Concrete
{
    public delegate 
    public class Bank : IBank
    {
        private List<IDesk> _desks;
        public string BankName { get; set; }
        public string Adress { get; set; }
        public int DeskCount { get; set; }
        public List<IDesk> Desks { get; set; }
            
        

        public void StartWork()
        {
            Console.WriteLine("banka çalışmaya başladı");

            foreach (var desk in _desks)
            {
                Console.WriteLine($"Gişe no: {desk.Name} Sır No: {desk.ProcessNumber} Durum: ");
            }
            CustomerWaiting.waitingCustomerVIP = new List<CustomerVIP>();
            CustomerWaiting.waitingCustomerDesk= new List<CustomerDesk>();
            CustomerWaiting.waitingCustomerStandart = new List<CustomerStandart>();
        }

        private void CreateDesk(int DeskCoun)
        {
            if (DeskCount <= 3)
            {
                Desks = new List<IDesk>();
                for (int i = 0; i < DeskCount; i++)
                {
                    Desk desk = new Desk() { Name = "ba-" + i, Status = false, ProcessNumber = 0 };
                }
            }
            else
            {
                throw new Exception("en fazla üç gişe olabilir");
            }
        }
    }
}
