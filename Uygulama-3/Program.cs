using Uygulama_3;

internal class Program
{
     static void Main(string[] args)
    {
       Cello cello = new Cello();
        cello.Markası = "Cellcon";
        cello.Aciklamasi = "Pahalıdır";

        Muzisyen cellocu = new Muzisyen();
        cellocu.Adi = "Naime";
        cellocu.Soyadi = "damataşı";
        cellocu.CaldigiEnsturman = cello; /// !!!!!!!!!!! Önemli

        Console.WriteLine(cellocu.Adi + " " + cellocu.Soyadi + " " + cellocu.CaldigiEnsturman.Markası);
    }
} 