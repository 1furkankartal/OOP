using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Ornek
{
    public delegate void HizAsimEventHandler(); // Delegate oluşturuldu event tanımlayabilmek için
    public class Araba
    {
        public event HizAsimEventHandler HizAsimi; // Eventi delegate e bildirme Tanımladnı
        private string _model;
        private int _hiz;
        public string Model {
            get { return _model; }
            set { _model= value; }
        }
        public int Hiz {
            get { return _hiz; }
            set 
            {
                _hiz= value;
                if(value > 120)
                {
                    //Event tetiklemesi
                    HizAsimi();
                }
            }
        }


    }
}
