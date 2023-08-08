using Event_Ornek;
using System;
class Program
{

    static void Main()
    {
        Araba araba = new Araba { Model = "TOGG", Hiz = 40 };
        araba.HizAsimi += new HizAsimEventHandler(HizLimiti); 
        // Event tetiklendiğinde += çalışacak metotlar sağa yazılır.
        for (int i = 10; i <250 ; i+=10)
        {
            araba.Hiz += i;
            Console.WriteLine(araba.Hiz);
            Thread.Sleep(1000);
        }

    }
    public static void HizLimiti()
    {
        Console.WriteLine("Araç hız limitini aştı");
    }
}

