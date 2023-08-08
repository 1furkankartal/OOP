using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universite
{
    public class Ogretmen:Personel
    {
        public string Brans { get; set; }

        public Ogretmen() 
        {

        }
        public void DersAnlat(Ders ders)
        {
            if (Brans == ders.DersIsmi)
            {
                 Console.WriteLine($"Öğretmen Dersi anlatıyor....");

            }
            else
            {
                Console.WriteLine("Branşı dışı olduğu için öğretmen dersi anlatamıyor");
            }
        }
    }
}
