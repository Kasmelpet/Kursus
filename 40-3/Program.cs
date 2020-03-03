using System;

namespace _40_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast tal 1");
            string tal1 = Console.ReadLine();

            Console.WriteLine("Indtast tal 2");
            string tal2 = Console.ReadLine();

            double dtal1, dtal2, dresultat;
            try
            {
                dtal1 = Convert.ToDouble(tal1);
                dtal2 = Convert.ToDouble(tal2);
                dresultat = dtal1 + dtal2;

                Console.WriteLine(dresultat.ToString("N2"));
            }
            catch (Exception)
            {
                Console.WriteLine("Kan desværre kun regne med tal op til 2 mia.");
            }
        }
    }
}
