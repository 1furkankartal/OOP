namespace FirstApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int deger=1;
            bool numbercontrol=true;
            int[] maaslar = new int[0];
            string[] names = new string[0];


            do
            {
                Console.WriteLine("İşçi tipini girin: 1- Çırak 2-Kalfa 3-Usta 4- İşcileri görüntülemek");
                numbercontrol = int.TryParse(Console.ReadLine(), out deger);
                if (deger == 1 || deger == 2 || deger == 3)
                {
                    Array.Resize(ref maaslar, maaslar.Length + 1);
                    Array.Resize(ref names, names.Length + 1);
                    Console.WriteLine("çalışanın ismini gir");
                    names[names.Length - 1] = Console.ReadLine();
                    Console.WriteLine("İşçinin mesai saatini girin");
                    int himesai = int.Parse(Console.ReadLine());
                    Console.WriteLine("Haftasonu mesai saatini yazın");
                    int hsmesai = int.Parse(Console.ReadLine());

                    if (deger == 1)
                        maaslar[maaslar.Length - 1] = Cirak(himesai, hsmesai);
                    else if (deger == 2)
                        Kalfa(himesai, hsmesai);
                    else if (deger == 3)
                        Usta(himesai, hsmesai);
                    //else if (deger == 5)
                    //    numbercontrol = false;
                }
                else
                {
                    break;
                    Yazdir(maaslar, names);
                }

            } while (numbercontrol);

               
            

        }

        #region Metod
        public static int Cirak(int hi,int hs)
        {
            int toplam=3000;
            toplam = (100 * hi) + (200 * hs);
            return toplam;
        }

        public static int Kalfa(int hi, int hs)
        {
            int toplam = 3000;
            toplam = (100 * hi) + (200 * hs);
            return toplam;
        }

        public static int Usta(int hi, int hs)
        {
            int toplam = 3000;
            toplam = (100 * hi) + (200 * hs);
            return toplam;
        }

        public static void Yazdir(int[] maas, string[] isimler)
        {
            for (int i = 0; i < maas.Length; i++)
            {
                Console.WriteLine(isimler[i] + "isimli çalışanın maaşı: " + maas[i]);

            }
        }

        #endregion
    }
}