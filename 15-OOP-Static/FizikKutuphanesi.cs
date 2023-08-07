using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_Static
{
    public static class FizikKutuphanesi
    {
        public static decimal YerCekimiKuvveti { get { return 9.804562M; } }
        //const =>> Sabit değer kendiliğinden static olma özelliğine sahiptir. Dolayısıyla static olarak işaretlenemz
        public const int KaldirmaKuvveti = 12;
        public static readonly int IndirmeKuvveti = 2;


        public static void Kaldir()
        {
            Console.WriteLine("kaldırma Kuvveti");
        }

        // Static classlarda constructor olamaz.
    }
}
