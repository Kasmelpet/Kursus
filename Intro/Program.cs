using System;

namespace Intro
{
    class Program
    {
        /// <summary>
        /// Here the program starts
        /// </summary>
        /// <param name="args">List of arguments - only takes one at the moment</param>
        static void Main(string[] args)
        {
            Console.WriteLine(args[0]);
            Console.WriteLine("Hvad skal vi tælle til?");
            string input = Console.ReadLine();
            int cnt = 0;
            
            try
            {
                cnt = Convert.ToInt32(input);
            }
            catch (Exception)
            {
                Console.WriteLine("Kan desværre kun tælle med tal");
            }
            
            Console.WriteLine($"Tæller til: {cnt.ToString()}");
            Counter ctr = new Counter(1, cnt);
            ctr.DoCount();
        }
    }
}
