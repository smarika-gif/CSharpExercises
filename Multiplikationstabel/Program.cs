namespace Multiplikationstabel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            for (int i = 1; i <= 10; i++)
            {

                for (int j = 1; j <= 10; j++)
                {
                    int h = i * j;

                    // Feltbredden kan angives direkte i en interpoleret streng,
                    // f.eks. $"{tal, 4}

                    Console.Write($"{h,4}");
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            for (int d = 1; d <= 6; d++)
            {
                for (int e = 1; e <= 6; e++)
                {
                    int f = d + e;
                    if (f == 5)
                    {
                        Console.WriteLine($"" + (d, e));
                    }
                }
            }

            //Opgave 6
            for (int f = 1; f <= 10; f++)
            {
                if (Kvadrat(f) <= Tredobl(f))
                {
                    Console.WriteLine($"Tresdobl(" + f + ") ==" + Tredobl(f) + "\t Kvadrat(" + f + ")==" + Kvadrat(f));
                }
                else
                {
                    break;
                   
                }
                //Console.ReadKey();





            }
        }

        //Opgave 6

        public static int Tredobl(int tal)
        {
            return tal * 3;
        }

        public static int Kvadrat(int tal)
        {
            return tal * tal;
        }


    }


}
        
 