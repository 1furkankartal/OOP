using _03_InheritanceLAB;

internal class Program
{
    private static void Main(string[] args)
    {
        NormalUye normalUye= new NormalUye();
        NormalUye normalUye1= new NormalUye("Özel notlar","Yasin",2023);
        normalUye1.YillikUyelikHesapla();
        Console.WriteLine(normalUye1.ToString());
        VIPUye vIPUye = new VIPUye("Fatih", 2021);
        vIPUye.YillikUyelikHesapla();
        Console.WriteLine(vIPUye.ToString());

        string ad = "Ahmet";
        List<string> liste1 = new List<string>();
        liste1.Add("Yasin");
        liste1.Add(ad);

        List<NormalUye> normalUyes = new List<NormalUye>();
        normalUyes.Add(normalUye);
        normalUyes.Add(new NormalUye("Notlar","Yasin",2023));
        foreach(var item in normalUyes)
        {
            Console.WriteLine(item.ToString());
        }
        //ChildClassı (Alt Sınıfları) BaseClass (Ana Sınıf) üzerinden taşıyabiliriz.
        BaseUye[] klubUyeleri = new BaseUye[3] { normalUye, vIPUye, new VIPUye("Ahmet", 2019) };
        List<BaseUye> baseUyes = new List<BaseUye>() { normalUye, vIPUye, new VIPUye("Ahmet", 2019) };

        foreach(var item in klubUyeleri) // veya "var item in baseUyes"
        {
            if (item.GetType() == typeof(VIPUye))
            {
                Console.WriteLine("Evet");
            }
            else
                Console.WriteLine("Hayır");
        }
    }
}