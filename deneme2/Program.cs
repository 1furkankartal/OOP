internal class Program
{
    private static void Main(string[] args)
    {
        int x = 8;

       



        try
        {
            if (x < 6)
            {
                Console.WriteLine("sayı küçük");
            }
            else
            {
                throw new Exception("Sayı kücük değill");
            }
        }
        catch (Exception e)
        {

           
        }
    }
}