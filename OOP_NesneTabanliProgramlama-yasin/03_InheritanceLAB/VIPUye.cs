using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InheritanceLAB
{
    public class VIPUye : BaseUye
    {
        public VIPUye(string uyeAdi, int uyelikTarihi):base(uyeAdi,uyelikTarihi) //ctor tab
        {
            Console.WriteLine("VIP üye 2 parametreli Ana Yapıcı");
        }
        public void YillikUyelikHesapla()
        {
            _yillikUcret = 500 * 12 + 2000;
        }
    }
}
