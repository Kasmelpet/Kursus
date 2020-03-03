using System;

namespace _65_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Run(1);
        }

        private static void Run(int tries)
        {
            try
            {
                Console.WriteLine("Indtast 1. tal");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indtast 2. tal");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                int res = tal1 + tal2;
                Console.WriteLine("resultatet er " + res);
            }
            catch (Exception)
            {
                if (tries < 3)
                {
                    Console.WriteLine("Fejl - prøv igen");
                    tries++;
                    Run(tries);
                }
                else
                {
                    Console.WriteLine("Gider ikke lege mere, når du hele tiden laver fejl");
                }
            }
        }
    }
}
