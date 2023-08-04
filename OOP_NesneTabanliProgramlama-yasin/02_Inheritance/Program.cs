using _02_Inheritance;

internal class Program
{
    private static void Main(string[] args)
    {
        BasePhone basePhone= new BasePhone("AEG","Kablolu");
        Console.WriteLine("Telefon markası: " + basePhone.Brand + "\nDurumu: " + basePhone.Call()+"\nBağlantı durumu: "+ basePhone.ConnectionStatus());

        MobilePhone mobilePhone = new MobilePhone(true,false,"Nokia","3G");
        Console.WriteLine(mobilePhone.Brand + " "+ mobilePhone.Call()+ "\nBağlantı durumu: " + mobilePhone.ConnectionStatus());
        Console.WriteLine(mobilePhone.ToString());
        SmartPhone smartPhone = new SmartPhone("Apple", "5G", true, true, true);
        Console.WriteLine(smartPhone.Brand+"\n"+ smartPhone.DoVideoCall());
    }
}