using System;

namespace _60_4
{
    class Program
    {
        static void Main(string[] args)
        {
            UdskrivTal(1, 10);
        }
        public static void UdskrivTal(int fra, int til)
        {
            Console.WriteLine(fra);
            if (fra == til)
                return;

            fra++;
            UdskrivTal(fra, til);
        }
    }

}
