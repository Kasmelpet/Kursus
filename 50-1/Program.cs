using System;

namespace _50_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int x = 1; x <= 10; x++)
                {
                    if (i * x > 50)
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    Console.Write($"{i * x}\t");
                }
                Console.Write("\r\n");

            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int x = 1; x <= 10; x++)
                {
                    if (i * x > 50)
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    else
                        try
                        {
                            Console.ForegroundColor = (ConsoleColor)(i*x);
                        }
                        catch (Exception)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                    string tal = Convert.ToString(i * x);
                    Console.Write($"{tal.PadLeft(4)}");
                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
