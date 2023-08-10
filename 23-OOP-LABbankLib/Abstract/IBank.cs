using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_OOP_LABbankLib.Abstract
{
    public interface IBank
    {
         string BankName { get; set; }
         string Adress { get; set; }
         int DeskCount { get; set; }
        List<IDesk> Desks { get; set; }
        void StartWork();
    }
}
