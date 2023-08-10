using _23_OOP_LABbankLib.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Concrete
{
    public class Bank : IBank
    {
        private List<IDesk> _desks;
        public string BankName { get; set; }
        public string Adress { get; set; }
        public int DeskCount { get; set; }
        public List<IDesk> Desks {
            get { return _desks; }
            set
            {
                if (value.Count > DeskCount)
                {
                    throw new Exception("En fazla 3 gişe olabilir!");
                }
                else
                {
                    _desks = value;
                }
            }
        }

        public void StartWork()
        {
            Console.WriteLine("banka çalışmaya başladı");

            foreach (var desk in _desks)
            {
                Console.WriteLine($"Gişe no: {desk.Name} Sır No: {desk.ProcessNumber} Durum: ");
            }
        }
    }
}
