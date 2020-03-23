using System;
using System.Collections.Generic;
using System.Text;

namespace _80_5
{
    class Konto
    {
        public List<Transaktion> transaktioner;

        public Konto()
        {
            transaktioner = new List<Transaktion>();
        }

        public string Kontoudtog()
        {
            StringBuilder udtog = new StringBuilder();
            udtog.Clear();
            foreach (Transaktion trans in transaktioner)
            {
                udtog.AppendLine($"Dato: {trans.dato.ToShortDateString()} {trans.tekst,-12} {trans.beløb:N2}");
            }
            return udtog.ToString();
        }

        public void Saldo()
        {
            decimal Sum = new decimal();
            Sum = 0;

            foreach (Transaktion trans in transaktioner)
            {
                Sum += trans.beløb;
            }
            Console.WriteLine($"Saldo: {Sum:N2} kr.");
        }
    }
}
