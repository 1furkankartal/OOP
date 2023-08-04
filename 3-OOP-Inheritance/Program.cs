using _3_OOP_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        BasePhone basePhone = new BasePhone("AEG", "Kablolu Bağlantı");
        Console.WriteLine($"Telefon Markası: {basePhone.Brand} \n Durumu: {basePhone.Call()}");

        MobilePhone mobilePhone = new MobilePhone(true,false,"Nokia","3G");
        Console.WriteLine($"Telefon Markası: {mobilePhone.Brand} \n Durumu: {mobilePhone.Call()}");

        // SmartPhone smartPhone = new SmartPhone("Apple", "5G", true, false, true);


    }
}