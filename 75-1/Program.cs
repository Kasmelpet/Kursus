using System;
using System.Collections.Generic;

namespace _75_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listNr = new List<int>();

            listNr.Add(6);
            listNr.Add(7);
            listNr.Add(3);

            foreach (var item in listNr)
            {
                Console.WriteLine(item);
            }

            Dictionary<int, string> dirPairs = new Dictionary<int, string>();

            dirPairs.Add(1, "String 1");
            dirPairs.Add(2, "string 2");
            dirPairs.Add(3, "String 3");

            Console.WriteLine(dirPairs[2]);


        }
    }
}
