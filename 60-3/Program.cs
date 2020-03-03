using System;

namespace _60_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Resultat af 1 + 2 er\t\t: {Beregn(1, 2)}");
            Console.WriteLine($"Resultat af 1 + 2 + 3 er\t: {Beregn(1, 2, 3)}");
            Console.WriteLine($"Resultat af 1 + 2 + 4 + 5 er\t: {Beregn(1, 2, 4, 5)}");
        }

        static int Beregn(int a, int b)
        {
            return a + b;
        }

        static int Beregn(int a, int b, int c)
        {
            return Beregn(a, b) + c;
        }

        static int Beregn(int a, int b, int c, int d)
        {
            return Beregn(a, b) + Beregn(c, d);
        }
    }
}
