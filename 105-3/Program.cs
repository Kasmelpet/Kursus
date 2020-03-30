using System;

namespace _105_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Kursist k = new Kursist();
            k.id = 3;
            k.Navn = "Kasper";
            k.Skriv1();
            k.Skriv2();
        }
    }

   public abstract class  Person
    {
        public int id { get; set; }
        public string Navn { get; set; }

        public void Skriv1()
        {
            Console.WriteLine($"Person med id: {id} og navn: {Navn}");
        }

        public abstract void Skriv2();
       
    }

    public class Kursist : Person
    {
        public override void Skriv2()
        {
            Console.WriteLine($"Kursist med id: {id} og navn: {Navn}");
        }
    }

}
