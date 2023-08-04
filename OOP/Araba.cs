using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Araba
    {
        
        string _amodel;
        string _amarka;
        string _arenk;
        string _ayakit;
        int _adepo;

        public string Amodel { get => _amodel; set => _amodel = value; }
        public string Amarka { get => _amarka; set => _amarka = value; }
        public string Arenk { get => _arenk; set => _arenk = value; }
        public string Ayakit { get => _ayakit; set => _ayakit = value; }
        public int Adepo { get => _adepo; set => _adepo = value; }

        public static void Yakithesapla(string yakittipi,int depohacmi)
        {
            
                if (yakittipi == "benzin")

                    Console.WriteLine(25 * depohacmi);
                else if (yakittipi == "dizel")

                    Console.WriteLine(20*depohacmi);
                else if (yakittipi == "lpg")

                    Console.WriteLine(15*depohacmi);
      
        }
    }
}
