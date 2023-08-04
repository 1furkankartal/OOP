using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ACCESS MODIFIERS
            //Private(Gizli)
            //Bir değerin private olarak tanımlanması demek, o değişkene sadece kendi class’ı içinden                     ulaşılabileceği anlamına gelmektedir.Program içinde kesinlikle değiştirilmemesi gereken, kritik             kodlarda kullanılmaktadır.
            //Ayrıca; private, varsayılan erişim belirleyici tipidir.Örneğin; “int deneme = 0;” gibi bir değişken tanımlandığında program tarafından deneme değeri privateolarak algılanmaktadır.

            //Public(Genel)
            //Bir değerin public olarak belirtilmesi; o değerin, kod içinde herhangi bir yerden erişilebilir durumda olmasını sağlamaktadır.Public erişim belirleyici tipinde hiç bir kısıtlama yoktur.

            //Protected (Korunumlu)
            //Kod içinde bir değerin protected olarak tanımlanması; o değere, bulunduğu class ve ondan türetilen diğer sınıflar içinden erişilebilir olduğunu göstermektedir.Protected; bir anlamda, public ve private erişim belirleyicilerinin birleşimi olarak görülebilmektedir.

            //Internal(İçsel)
            //Internal olarak tanımlanan bir değer; aynı program içerisinden erişilebilir, fakat farklı bir program içerisinden erişilemez durumdadır.Program içerisinde herhangi bir kısıtlaması yoktur.

            //Protected Internal (İçsel Korunumlu)
            //Protected internal olarak tanımlanmış değer, tanımlandığı class’ın içinden ve ondan türetilen sınıfların içinden erişilebilir durumdadır.Türetilen sınıfın aynı program içinde olmaması sorun teşkil etmez.
            #endregion
            //Animal reykus = new Animal();
            //Animal reykus_1 = new Animal("dog");
            ////reykus.animalType = "cat";
            //reykus.setAnimalType("kus");
            //Console.WriteLine(reykus.getAnimalType());

            //for (int i = 0; i < 10; i++)
            //{
            //    Animal animal = new Animal();
            //    animal = null;
            //}

            #region Ornek-1

            //Console.WriteLine("kaç kullanıcı gireceksiniz");
            //int adet = int.Parse(Console.ReadLine());

            //Personal[] _personallist = new Personal[adet]; // Clasın türünde bir dizi oluşturuldu.

            //for (int i = 0; i < _personallist.Length; i++)
            //{
            //    Personal _personal = new Personal(); // Nesne oluşturuldu.
            //    _personal.PersonalId = 101;
            //    _personal.Sicilno = "adfagafafa";
            //    _personal.Ad = "furkan";
            //    _personal.Soyad = "kartal";
            //    _personallist[i] = _personal;
            //}

            //PersonelBilgileriGoster(_personallist);

            //void PersonelBilgileriGoster(Personal[] _persons)
            //{

            //    foreach (var item in _persons)
            //    {
            //        Console.WriteLine(item.Ad);
            //    }

            //}

            #endregion

            #region Ornek-2

            //Musteri[] musteriler = new Musteri[0];
            //string deger = "evet";
            //while (deger=="evet") 
            //{
            //    Console.WriteLine("müşteri girmek ister misin ?");
            //    deger = Console.ReadLine();
            //    if (deger == "evet")
            //    {
            //            Musteri musteri = new Musteri();
            //            Console.WriteLine("Girilecek müşterinin tipini yazın: (tm,bm,km,ym)");
            //            musteri.Mturu = Console.ReadLine();
            //            Array.Resize(ref musteriler, musteriler.Length + 1);
            //            Console.WriteLine("müsterinin adını girin");
            //            musteri.Mad = Console.ReadLine();
            //            musteriler[musteriler.Length-1] = musteri;                   

            //    }

            //}
            //Console.WriteLine("tür seç:");
            //string tur = Console.ReadLine();
            //foreach (var item in musteriler)
            //{
            //    if (item.Mturu == tur)
            //    {
            //        Console.WriteLine(item.Mad);
            //    }

            //}


            // döngünün içinde her seferinde nesne yeniden üretilmeli!!!!!

            #endregion

            #region Ornek-3
            //int benzin = 20, dizel = 25, lpg = 15;
            //char deger = 'e';
            //Araba[] cars = new Araba[0];
            //while (deger == 'e')
            //{
            //    Console.WriteLine("araç girmek istiyorsan e ye bas");
            //     deger = char.Parse(Console.ReadLine());
            //    if (deger != 'e') break;
            //    Array.Resize(ref cars, cars.Length + 1);
            //    Araba car = new Araba();
            //    Console.WriteLine("aracın markasını girin");
            //    car.Amarka = Console.ReadLine();
            //    Console.Write("aracın yakıt tipini giriniz");
            //    car.Ayakit = Console.ReadLine();
            //    Console.WriteLine("aracın depo hacmini giriniz");
            //    car.Adepo = int.Parse(Console.ReadLine());
            //    cars[cars.Length - 1] = car;

            //}


            //foreach (var item in cars)
            //{
            //    Araba.Yakithesapla(item.Ayakit,item.Adepo);
            //}


            #endregion

            #region Motobike

            Motobike motor = new Motobike();
            motor.marka = "bmw";
            motor.model = "s1000rr";


            Console.WriteLine("motor girişi yap 'e' ");


            #endregion
        }
    }
}