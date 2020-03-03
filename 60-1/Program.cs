using System;

namespace _60_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Udskriv(Convert.ToString(LægSammen(5, 2)));
            
            Udskriv(Convert.ToString(BeregnAreal(5)));

            Udskriv("Så er vi færdige med at regne.");
        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(int radius)
        {
            return radius * radius * System.Math.PI;
        }

        static void Udskriv(string txt)
        {
            Console.WriteLine(txt);
        }

    }
}
