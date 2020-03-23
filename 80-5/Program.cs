using System;

namespace _80_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Konto k = new Konto();
            k.transaktioner.Add(new Transaktion(new DateTime(2019, 1, 1), "Indsat", 100));
            k.transaktioner.Add(new Transaktion(new DateTime(2019, 2, 1), "Indsat", 250));
            k.transaktioner.Add(new Transaktion(new DateTime(2019, 3, 1), "Hævet", -75));
            k.Saldo();
            Console.WriteLine(k.Kontoudtog());
        }
    }
}
