using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InheritanceLAB
{
    internal class NormalUye : BaseUye
    {
        public NormalUye()
        {
            Console.WriteLine("Normal Üye Parametresiz Alt Yapici");
        }
        public NormalUye(string notlar): base ("Yasin",2021)
        {
            Console.WriteLine("Normal Üye Parametreli Alt Yapıcı");
            Console.WriteLine("Notlar = {0}", notlar);
        }
        public NormalUye(string notlar, string uyeAdi, int uyeTarihi): base(uyeAdi, uyeTarihi)
        {
            Console.WriteLine("Normal Üye 3 parametreli alt yapıcı");
            Console.WriteLine("Notlar = {0}", notlar);
        }

        public void YillikUyelikHesapla()
        {
            _yillikUcret = 300 * 12;
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
