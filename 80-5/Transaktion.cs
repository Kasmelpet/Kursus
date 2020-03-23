using System;
using System.Collections.Generic;
using System.Text;

namespace _80_5
{
    class Transaktion
    {
        public DateTime dato;
        public String tekst;
        public decimal beløb;

        public Transaktion(DateTime dato, String tekst, decimal beløb)
        {
            this.dato = dato;
            this.tekst = tekst;
            this.beløb = beløb;
        }
    }
}
