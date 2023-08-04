using Sahibinden;
char deger='e';
Arabalar yeniaraba = new Arabalar();
yeniaraba.fiyat = 250;
Arabalar[] _arabalar = new Arabalar[0];


do
{
    Array.Resize(ref _arabalar, _arabalar.Length+1);
    Arabalar tekaraba = new Arabalar();

    Console.Write("aracın markasını gir:");
    tekaraba.marka = Console.ReadLine();
    Console.Write("aracın fiyatını gir:");
    tekaraba.fiyat = int.Parse(Console.ReadLine());
    Console.Write("aracın modelini gir:");
    tekaraba.model = Console.ReadLine();
    Console.Write("aracın km gir:");
    tekaraba.km = int.Parse(Console.ReadLine());

    _arabalar[_arabalar.Length-1] = tekaraba;

    Console.WriteLine("yeni araç girmek ister misiniz:");
    deger = char.Parse(Console.ReadLine());   
    
} while (deger=='e');

Console.WriteLine("km sınırı gir:");
int kmsinir = int.Parse(Console.ReadLine());

foreach (var araba in _arabalar)
{
    AracSirala(araba.km, kmsinir,_arabalar);
}

 static void AracSirala(int km, int sinir, Arabalar[] arabalars)
{
    if (km < sinir)
    {
        Console.WriteLine();
    }
}