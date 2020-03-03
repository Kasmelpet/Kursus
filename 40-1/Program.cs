using System;

namespace _40_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal.ToString()); // 30

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal.ToString()); // 25

            int divtal1 = 39;
            int divtal2 = 4;
            int resultat = divtal1 / divtal2;
            Console.WriteLine(resultat.ToString()); // 39/4 = 9

            double ddivtal1 = 39.0;
            double ddivtal2 = 4.0;
            double dresultat = ddivtal1 / ddivtal2;
            Console.WriteLine(dresultat.ToString()); // 39/4 = 9.75

            double dTal = 200334.4333;
            Console.WriteLine(dTal.ToString());
            Console.WriteLine(dTal.ToString("N2"));
            Console.WriteLine(dTal.ToString("N3"));
            Console.WriteLine(dTal.ToString("F2"));
            Console.WriteLine(dTal.ToString("C2"));
            Console.WriteLine(dTal.ToString("P2"));

            double dPct = 0.335;
            Console.WriteLine(dPct.ToString("P0"));

        }
    }
}
