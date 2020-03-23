using System;

namespace _80_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Beregninger b = new Beregninger();

            int res = Beregninger.LægSammen(1, 1);
            Console.WriteLine(res);

        }
    }

    public class Beregninger
    {
        public static int LægSammen(int a, int b)
        {
            return a + b;
        }
        public static int TrækFra(int a, int b)
        {
            return a - b;
        }

        private Beregninger()
        {

        }
    }
}
