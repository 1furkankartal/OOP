internal class Program
{
    static void Main(string[] args)
    {
        GonderDelegate delegate1 = new GonderDelegate(SmsGonder);
        //delegate1.Invoke("hata mesajı...");
        delegate1 += MailGonder;
        delegate1 += DataBaseYaz;
        delegate1("hata mesajı...");
        delegate1.Invoke("furkan");
    }

    public delegate void GonderDelegate(string durummesaji);
    public static void SmsGonder(string durummesaji)
    {
        Console.WriteLine(durummesaji);
    }

    public static void MailGonder(string durummesaji)
    {
        Console.WriteLine(durummesaji);
    }

    public static void DataBaseYaz(string durummesaji)
    {
        Console.WriteLine(durummesaji);
    }

}