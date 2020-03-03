using System;

namespace _50_2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 19; i++)
            {
                if (i > 15)
                    break;

                if (i % 3 != 0)
                    continue;

                Console.WriteLine(i);

            }
        }
    }
}
