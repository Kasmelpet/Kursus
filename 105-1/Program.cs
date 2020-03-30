using System;

namespace _105_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktura f = new Faktura();
            f.Nr = 3;
            f.Dato = DateTime.Now;
            f.Kunde = "Kasper";
            Console.WriteLine(f.ToString());

        }
    }

    class Faktura
    {
        public int Nr { get; set; }
        public DateTime Dato { get; set; }
        public string Kunde { get; set; }

        public override string ToString()
        {
            return $"Faktura nr.: {Nr}. Kunde: {Kunde} Dato: {Dato}";
        }
    }
}
