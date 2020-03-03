using System;

namespace _40_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1;
            d1 = DateTime.Now;
            Console.WriteLine($"Current time: {d1}");

            d1 = d1.AddDays(10);
            Console.WriteLine($"10 days later... {d1}");

            d1 = d1.AddMinutes(20);
            Console.WriteLine($"20 min later... {d1}");

            d1 = d1.AddMonths(-1);
            Console.WriteLine($"1 month earlier: {d1}");

            DateTime d2, d3;
            d2 = DateTime.Now;
            d3 = new DateTime(2018, 3, 12);

            TimeSpan s1 = d2 - d3;
            Console.WriteLine($"forskel mellem {d2} og {d3} er {s1.Days} dage");

            TimeSpan t2, t3, t4, t5;
            t2 = new TimeSpan(16, 0, 0);
            t3 = new TimeSpan(0, 30, 0);
            t4 = t2 - t3;
            t5 = t2 + t3;

            Console.WriteLine($"T2: {t2}");
            Console.WriteLine($"T3: {t3}");
            Console.WriteLine($"T2 - T3: {t4}");
            Console.WriteLine($"T2 + T3: {t5}");

        }
    }
}
