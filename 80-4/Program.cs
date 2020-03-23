using System;

namespace _80_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder().ToString());

            Person p2 = new Person("Kash", "Pet", 1978);
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder().ToString());

            Person p3 = new Person("Jan", "Finsen", 1980);
            Console.WriteLine(p3.FuldtNavn());
            Console.WriteLine(p3.Alder().ToString());

        }
    }
}
