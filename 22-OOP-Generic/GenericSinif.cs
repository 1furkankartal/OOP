using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOP_Generic
{
    //Kısıtlamalar
    //1) class anahtar kelimesini constractions kısıtlama olarak belirtirsem sadece referans tipli değer atanacağını garanti etmiş oluruz.
    //2)struct anahtar kelimesini constrations (kısıtlama) olarak belirtirsem sadece value tipli değer atanacağını gaaranti etmiş olurum.
    //3) base class ismini constrations (kısıtlama) olarak belirtirsem saddece base class ve ondan türeyen sub class ların atanacağını garanti etmiş olurum.
    public class GenericSinif<T> where T: class
    {
        private T _id;

        public T[] _dizi = new T[5];
        public T ID { get; set; }
        public T Name { get; set; }
        public int Age { get; set; }

        public void VeriEkle(T index, T data)
        {
            //Komutlar..
        }

        public void VeriEkle(string index, T data)
        {
            //komutlar..
        }

        public T VeriGetir(int index)
        {
            if (index>=0 && index<5)
            {
                return _dizi[index];
            }
            else
            {
                return default(T); // Ttipi ne gelirse onun default değerini return etsin demek.
            }
            return default(T);
        }
    }

    public class GenericOlmayanSinif 
    {
        public void  EkranaYaz<T>(T veri) where T : struct
        {
            Console.WriteLine();
        }
    }
}
