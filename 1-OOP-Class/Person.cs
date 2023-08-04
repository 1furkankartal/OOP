using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_OOP_Class
{
    internal class Person
    {
        public Person()
        {
            Console.WriteLine("instance gerçekleşti");
        }

        public Person(string personelIsmi,int sure)
        {
           this.Name=personelIsmi;
            this.Sure=sure;

        }   

        private int _sure;
        private string _name;
        public string Name { get { return _name; } set { _name = value; } }

        public int Sure
        {
            get
            {
                return _sure;
            }
            set
            {
                if (value > 0)
                {
                    _sure = value;
                }
                else
                {
                    Console.WriteLine("0 dan küçük değer girilemez");
                }
            }
        }

        public void MesajYaz()
        {
            Console.WriteLine("maaş hesaplanıyor");
        }

        public int MaasHesapla()
        {
            MesajYaz();
            int personelMaas;
            personelMaas = _sure * 350;

            if(_sure>0)
            {
                return personelMaas;
            }
            else
            {
                return 0;
            }
        }

        public int MaasHesapla(int avans)
        {
            MesajYaz();
            int personelMaas;
            personelMaas = (_sure * 350)+avans;

            if (_sure > 0)
            {
                return personelMaas;
            }
            else
            {
                return 0;
            }
        }
    }
}
