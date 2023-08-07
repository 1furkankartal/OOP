using _15_OOP_Static;

internal class Program
{
    private static void Main(string[] args)
    {
        //Static Class
        //Eğer nesneye bağımlı işlemler gerçekleştriilmiyorsa yani sadece amaç belirli bir duruma hizmet eden birden fazla öğeyi bir araya toplamak ise ilgili sınıfı static olarak işaretleyebilir içerisinde tüm öğeleri instance dan bağımsız kullanabilirsiniz

        // Static sınıfların içinde yalnızca static öğeler bulunabilir(Field, property, method)

        //Static Classlar bir başka sınıftan kalıtım alamaz. .net framework mantığında tüm yapılar system.objectden kalıtım alırlar. Static sınıfda bu kalıtım işlemine dahildir.

        // Math ve File 

        // Static sınıflar ufakta olsa performans kaybına neden olur.

        // STATİC SINIF PROPERTY METOD YAPILDI.

        YeniSinif.Yas = 36;

        YeniSinif yeniSinif1 = new YeniSinif();
        yeniSinif1.adi = "Furkan";
        yeniSinif1.AdiGoster();
        YeniSinif.YasGoster();
    }
}