using _22_OOP_Generic;

internal class Program
{
    // generic c# programlama dilinde yeniden kullanılabilir type safe (tip güvenli) koduun oluştuurlmasına veya oluşturmasına izin veren bir özelliğidir.
    private static void Main(string[] args)
    {
        PrintData<string>("MERHABA");

        PrintData<int>(110);

        PrintData<bool>(true);

        GenericSinif<string> ogrenci = new GenericSinif<string>();
        ogrenci.ID = "5";
        ogrenci.Name = "Fatih";
        ogrenci.Age = 30;

        //!! İLK ATANDIĞI TÜRDE KALIYOR TİPİ

        //GenericSinif<int> ogrenci2 = new GenericSinif<int>();
        //ogrenci.ID = "4";
        //ogrenci.Name = "2132";
        //ogrenci.Age = 30;

        AnahtarDegerIkilisi<int, string> anahtarDegerIkilisi = new AnahtarDegerIkilisi<int, string>();
        anahtarDegerIkilisi.ID = 1;
        anahtarDegerIkilisi.Name = "fATİH";
       
    }

    public static void PrintData<T>(T data)
    {
        Console.WriteLine("data: "+data);
    }
}