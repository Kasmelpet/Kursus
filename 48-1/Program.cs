using System;

namespace _48_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int kort1værdi = 2;
            Suits kort1kulør = Suits.Hjerter;

            int kort2værdi = 3;
            Suits kort2kulør = Suits.Ruder;

            Console.WriteLine($"Kort 1 er værdien:\t {kort1værdi} af kulør:\t {kort1kulør} - {(int)kort1kulør}");
            Console.WriteLine($"Kort 2 er værdien:\t {kort2værdi} af kulør:\t {kort2kulør} - {(int)kort2kulør}");



        }
    }
}
