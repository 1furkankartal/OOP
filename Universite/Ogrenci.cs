using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universite
{
    public class Ogrenci:Person
    {
        public int OkulNumarasi { get; set; }

        public void DersAl(Ogretmen ogretmen)
        {
            Console.WriteLine($"Öğrenci {ogretmen.Brans} dersi alıyor ");
        }

        public void PuanVer(Ders ders)
        {
            Console.WriteLine(this.Ad + " " + ders.DersIsmi + " dersine puan verebilirsiniz");
            int puan = int.Parse(Console.ReadLine());
            ders.DersZorlukSeviyesi = puan;
        }
    }
}
