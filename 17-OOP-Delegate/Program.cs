using System.Security.Cryptography.X509Certificates;

internal class Program
{
    //Delegate bir metoda atıfta bulunan nesnedir. Bir başka deyişle etotlara referans oluşturabilen referans tipli değişkendir.
    //Basit bir ifadeyle delegateler belirli parametrelere e dönüş tipine sahip metotları üzerinde taşıyabilen ve gerektiği anda kullanabilen yapıalrdır.
    // İpucu: Metotları kapsüllemek için iyi bir yol sağlar. Genellikle Call back olarak bilinen metotların ve eventlerin uygulanmasında kullanılır.

    // Syntax:
    // Acces Modifer - delegate - return type - delegate name - parametre list?

    static void Main(string[] args)
    {
        //numDelegate sumdelegate = new numDelegate(Sum);
        //sumdelegate(10, 5);

        //numDelegate substractdelegate = new numDelegate(Substract);
        //substractdelegate(10, 5);

        //CalculateDelegate calculateDelegate = new CalculateDelegate(Area);
        //calculateDelegate += Perimeter;

        //calculateDelegate(20, 50);
        //calculateDelegate.Invoke(25, 25);

        #region PredicateDelegateCagirma
        Predicate<int> predicate = IsTeenger;
        Console.WriteLine(predicate(23));
        #endregion

        #region FuncDelegateCagirma
        Func<int, int, int> func = Sum1;
        int result = func(5, 3);
        Console.WriteLine("Toplam: " + result);
        #endregion

        #region ActionDelegateCagirma

        Action<string> action = ConsolePrint;
        action("Ders Bitti");
        #endregion
    }
    #region single delegate kllanımı
    //Geriye değer döndürmeyen iki adet parametre alan bir delegate tanımladık.
    public delegate void numDelegate(int a, int b);

    public static void Sum(int a, int b)
    {
        Console.WriteLine("Toplam: {0}", a + b);
    }
    public static void Substract (int a, int b)
    {
        Console.WriteLine("Fark: {0}", a - b);
    }
    #endregion

    #region MulticastingDelegate
    // Tek bir açğrıda birden fazla metodu işaret etmesine yardımcı olur.

    //"+" veya "+=" operatörlerini kullanıcam
    // "-" veya "-=" operatörlerini kullanıcam
    // First in first out (FIFO) İLK GİREN İLK ÇIKAR MANTIĞIYLA ÇALIŞIR

    public delegate void CalculateDelegate(int width, int height);

    public static void Area(int width, int height)
    {
        Console.WriteLine("Alan {0}", (height * height));
    }

    public static void Perimeter(int width, int height)
    {
        Console.WriteLine("Çevre {0}",(2 * (height * width)));
    }

    #endregion

    #region PredicateDelegate
    // Belirli kriterler içeren metotlarla çalışır ver verilen kriterlerin karşılanıp karşılanmadığına bakar (Geriye bool döner.)

    public static bool IsTeenger(int age)
    {
        if (15<age && age<25)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    #endregion

    #region FuncDelegate
    // Geriye belirli bir değer döndüren delegate türüdür. (16 adete kadar parametre alabilir ama son parametrenin  geriye dönüş parametresidir.)
    public static int Sum1(int x,int y)
    {
        return x + y;
    }
    #endregion

    #region ActionDelegate
    // Function delegate ile aynıdır ama geriye değer dönmez voiddir.
    public static void ConsolePrint(string text)
    {
        Console.WriteLine(text);    
    }
    #endregion
}