using Uygulama_5;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Maaş hesaplama Programına hoş geldiniz");

        List<PersonBase> persons = new List<PersonBase>();

        bool status = true;
        while(status)
        {
            Console.Write(" Adınız");
            string name = Console.ReadLine();

            Console.Write("dOĞUM tARİHİ");
            int birthDate = int.Parse(Console.ReadLine());

            Console.Write("üNVANI");
            string title = Console.ReadLine();

            Console.Write("sAATLİK ÜCRET");
            int hourlyWage = int.Parse(Console.ReadLine());

            Console.Write("Çalışma Saati");
            int workinghour = int.Parse(Console.ReadLine());

            if (title == "memur")
            {
                persons.Add(new PersonStandart(name,birthDate,hourlyWage,workinghour));
            }

            else
            {
                Console.Write("Bonus: ");
                double bonus  = Convert.ToDouble(Console.ReadLine());

                persons.Add(new PersonAdmin(name,birthDate,hourlyWage,workinghour,bonus));
            }

            Console.WriteLine("Devam mı?"),
                status = Console.ReadLine().ToLower()=="yes" ? true : false;

        }

        foreach (var item in persons)
        {
            item.CalculateWage();
            Console.WriteLine(item.ToString());
        }
    }
}