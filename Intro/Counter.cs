using System;

namespace Intro
{
    class Counter
    {

        int start;
        int stop;

        public Counter(int min, int max)
        {
            start = min;
            stop = max;
        }

        public void DoCount()
        {
            for (int i = start; i <= stop; i++)
            {
                ConsoleColor defColor = Console.ForegroundColor;

                Console.ForegroundColor = ConsoleColor.Red;
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                Console.WriteLine($"Har nu talt til: {i.ToString()}");

                Console.ForegroundColor = defColor;
            }
        }
    }
}
