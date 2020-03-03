using System;

namespace _60_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = @"c:\temp\test.txt";

            if (System.IO.File.Exists(filename))
            {
                Console.WriteLine("File findes! Halleluja.");
                string[] indhold = System.IO.File.ReadAllLines(filename);
                foreach (var item in indhold)
                {
                    Console.WriteLine(item);
                }
                

                Console.WriteLine();

                var fil = new System.IO.FileInfo(filename);
                Console.WriteLine($"Sidst redigeret\t\t:\t{fil.LastAccessTime}");
                Console.WriteLine($"Filen er af type\t:\t{fil.Extension}");

            }


        }
    }
}
