using _1_OOP_Class;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("furkan kartal");

        Person person= new Person();
        person.Name = "furkan";
        person.Sure = 120;

        Console.WriteLine(person.Name + " maaşı: " + person.MaasHesapla());

        Console.WriteLine(person.MaasHesapla(1500));

        Console.WriteLine("*******************************************************");

        Person person2= new Person("merve",24);
        Console.WriteLine(person2.MaasHesapla());
    }
}