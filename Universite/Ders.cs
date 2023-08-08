using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Universite
{
    public class Ders
    {
        public Ders()
        {
            ogrenciler = new Ogrenci();
            
        }

        public List<Ogrenci> ogrenciler { get; set; }

        public Ogretmen Ogretmen { get; set; }
        public List<Ogrenci> Ogrenci { get; set; }
        public string DersIsmi { get; set; }
        public int DersZorlukSeviyesi { get; set; }

        public void DersBasla()
        {
            if(Ogretmen.Brans == DersIsmi && Ogretmen.MusaitMi&& Ogrenci.Count > 10)
            {
                Console.WriteLine("Ders Verildi");

                foreach(Ogrenci o in ogrenciler)
                {
                    DersZorlukSeviyesi += o.PuanVer();
                }

                this.DersOrtalamasi();
            }
            else
            {
                Console.WriteLine("Uygun koşullar sağlanamadığından ders verilemedi");
            }
        }

        public void DersOrtalamasi()
        {
            Console.WriteLine("Dersin zorluk seviyesi: " + (DersZorlukSeviyesi / ogrenciler.Count));
        }
    }
}
