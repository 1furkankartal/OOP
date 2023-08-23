using _23_OOP_LABbankLib.Abstract;
using _23_OOP_LABbankLib.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        //Gişe oluştur 
        List<IDesk> desklist = new List<IDesk>();
        desklist.Add(new Desk() { Name = "B1", Status = false, ProcessNumber = 0 });
        desklist.Add(new Desk() { Name = "B2", Status = false, ProcessNumber = 0 });
        desklist.Add(new Desk() { Name = "B3", Status = false, ProcessNumber = 0 });

        //Banka çalıştır
        Bank bank = new Bank();
        bank.BankName = "BilgeAdam";
        bank.DeskCount = 3;
        bank.Desks = desklist;
        bank.StartWork();

        //Musteri Oluştur
        CustomerDesk customer1 = new CustomerDesk("111", "fatih1");
        customer1.GetNumber();

        CustomerDesk customer2 = new CustomerDesk("111", "fatih1");
        customer1.GetNumber();

        CustomerDesk customer3 = new CustomerDesk("111", "fatih1");
        customer1.GetNumber();

        

        

    }
}