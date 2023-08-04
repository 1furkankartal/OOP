using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InheritanceLAB
{
    public class BaseUye
    {
        Guid guid = new Guid();
        private string _uyeId = Guid.NewGuid().ToString().Substring(1, 4); //Rastgele bir anahtarı 1'den 4'e kestik.
        private string _uyeAdi;
        private int _uyelikTarihi;
        protected int _yillikUcret;

        public BaseUye()
        {
            Console.WriteLine("BaseUye Parametresiz ana yapıcı");
        }
        public BaseUye(string uyeAdi, int uyelikTarihi)
        {
            Console.WriteLine("BaseUye Parametreli ana yapıcı");
            _uyeAdi= uyeAdi;
            _uyelikTarihi=uyelikTarihi;
        }

        public override string ToString()
        {
            return $"\nÜye Adı: {_uyeAdi}\nÜye Id: {_uyeId}\nÜye Kayıt Tarihi: {_uyelikTarihi}\nYıllık Ücret: {_yillikUcret}";
        }
    }

}
