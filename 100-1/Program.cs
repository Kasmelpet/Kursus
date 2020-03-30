using System;

namespace _100_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Kasper";
            p1.Efternavn = "Petersen";
            Console.WriteLine(p1.FuldtNavn());

            Elev e1 = new Elev();
            e1.Fornavn = "Ruth";
            e1.Efternavn = "Jensen";
            e1.Klasselokale = "A";
            Console.WriteLine(e1.FuldtNavn());

            Instruktør i1 = new Instruktør();
            i1.Fornavn = "James";
            i1.Efternavn = "Smidth";
            i1.NøgleId = 6
            Console.WriteLine(i1.FuldtNavn());

        }
    }

    public class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }
    }

    public class Elev : Person
    {
        public string Klasselokale { get; set; }
    }

    public class Instruktør : Person
    {
        public int NøgleId { get; set; }
    }
}
