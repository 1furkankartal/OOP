internal class Program
{
    private static void Main(string[] args)
    {
        //Tightly Coupling (Sıkı Bağlantı) A ve B SINIFLARIMIZ OLSUN B SINIFINI BAAĞIMSIZ OLARAK KULLANAMDIĞIMIZ YALNIZCA A SINIFININ İEÇRİSİNDE KULLANABİLDĞİMİZ BİR SENARYO SIKI BAĞLANTIDIR
        Console.WriteLine("Hello, World!");

        string path = @"C:\Users\halkbank\Desktop\deneme.txt";
        if (File.Exists(path))
        {
            File.Delete(path);
            File.WriteAllText(path, "Merhaba Dünya");
        }
        else
        {
            File.Create(path);
            StreamWriter streamwriter;
            using()
            File.WriteAllText(path, "Merhaba karideşşş");
        }


        File.Create(@"C:\Users\halkbank\Desktop\deneme.txt");
        File.WriteAllText(@"C:\Users\halkbank\Desktop\deneme.txt", "Merhaba kariideşşş");
    }
}