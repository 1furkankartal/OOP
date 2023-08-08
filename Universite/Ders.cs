using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Universite
{
    public class Ders
    {
        public Ogretmen Ogretmen { get; set; }
        public Ogrenci Ogrenci { get; set; }
        public Guvenlik Guvenlik { get; set; }
        public string DersIsmi { get; set; }
        public int DersZorlukSeviyesi { get; set; }
        public int DersiAlanOgrenciSayisi { get; set; }

        public void DersBasla()
        {
            Ogretmen.DersAnlat(this);
            Ogrenci.DersAl(Ogretmen);
            Guvenlik.Koru();
            // Ogrenci.PuanVer(Ders ders);
        }
    }
}
