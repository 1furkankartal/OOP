using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTU
{
    internal class Features
    {
        
        private string _marka;
        private bool _kazanlimi;
        private int _fiyat;
        private int _suseviyesi;
        private int _sicaklik;

        public string Marka { get => _marka; set => _marka = value; }
        public bool Kazanlimi { get => _kazanlimi; set => _kazanlimi = value; }
        public int Fiyat { get => _fiyat; set => _fiyat = value; }
        public int Suseviyesi { get => _suseviyesi; set => _suseviyesi = value; }
        public int Sicaklik { get => _sicaklik; set => _sicaklik = value; }
        public int Hiz { get; set; }



        public Features(int seviye,int sicaklik)
        {
            this.Suseviyesi = seviye;
            this.Sicaklik= sicaklik;    
        }


        public int Suderecesi()
        {
            _suseviyesi -= 5;
             return _suseviyesi;
        }

        public void Isit()
        {
        _sicaklik += 10;
           
        }

        public void BilgiVer()
        {
            Console.WriteLine(_sicaklik);
        }

        public void Kmkontrol()
        {
            Hiz+= 10;
        }

        
    }
}
