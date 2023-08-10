using _21_OOP_Serialization;

internal class Program
{
    public static void Main(string[] args)
    {
        string path = @"C:\Users\halkbank\Desktop\";

        Person person= new Person();
        person.Name = "Bİlge";
        person.SurName = "KADIN";
        person.Age= 30;

        BinarySerialize.SerializeToBinary(person, path+"Person.dat");
        Console.WriteLine("Binary Serialize Gerçekleşti");

        Person person1= new Person();
        BinarySerialize.DeserializeToBinary(out person1, path + "person.dat");
        Console.WriteLine($"ID: {person1.Id} Name: {person1.Name} Surname: {person1.SurName}");
    }
}