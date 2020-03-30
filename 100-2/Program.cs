using System;

namespace _100_2
{
    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(r.NextBool().ToString());
            }
            
        }
    }

    class UdvidetRandom : Random
    {
        public bool NextBool()
        {
            int rndno = new Random().Next(1, 1002);
            return (rndno % 2 == 0);

        }
    }
}
