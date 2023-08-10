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
        Customer customer1 = new Customer("111", "fatih1", _23_OOP_LABbankLib.Enums.CustomerType.DeskCustomer);
        CustomerWaiting.waitingCustomers.Add(customer1);
        customer1.GetNumber();

        Customer customer2 = new Customer("112", "fatih1", _23_OOP_LABbankLib.Enums.CustomerType.DeskCustomer);
        CustomerWaiting.waitingCustomers.Add(customer1);
        customer1.GetNumber();

        Customer customer3 = new Customer("113", "fatih1", _23_OOP_LABbankLib.Enums.CustomerType.StandartCustomer);
        CustomerWaiting.waitingCustomers.Add(customer1);
        customer1.GetNumber();

        Customer customer4 = new Customer("114", "fatih1", _23_OOP_LABbankLib.Enums.CustomerType.StandartCustomer);
        CustomerWaiting.waitingCustomers.Add(customer1);
        customer1.GetNumber();


        Customer customer5 = new Customer("115", "fatih1", _23_OOP_LABbankLib.Enums.CustomerType.StandartCustomer);
        CustomerWaiting.waitingCustomers.Add(customer1);
        customer1.GetNumber();

        Console.WriteLine("gLEN KİŞİLER:");
        Console.WriteLine($"vıp: {Numerator.}")

        desklist[0].DoAction();

    }
}