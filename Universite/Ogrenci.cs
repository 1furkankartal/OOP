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
        public string Ders { get; set; }

        //public void DersAl(Ogretmen ogretmen)
        //{
        //    Console.WriteLine($"Öğrenci {ogretmen.Brans} dersi alıyor ");
        //}

        public int PuanVer()
        {
            Console.WriteLine(ders.DersIsmi+" dersine puan verebilirsiniz.");
            int puan = int.Parse(Console.ReadLine());
            return puan
        }
    }
}
