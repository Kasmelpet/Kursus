using System;
using System.Collections.Generic;
using System.Text;

namespace _80_2
{
    class Terning
    {
        public int vaerdi;
        private bool snyd;

        public Terning()
        {
            vaerdi = 1;
            snyd = false;
        }

        public Terning(bool snyd)
        {
            vaerdi = 1;
            this.snyd = snyd;
        }

        public void Skriv()
        {
            Console.WriteLine($"[{vaerdi}]");
        }

        public void Ryst()
        {
            int tal;
            if (snyd)
            {
                tal = 6;
            }
            else
            {
                System.Random rnd = new System.Random();
                tal = rnd.Next(1, 7);
            }
            
            vaerdi = tal;

        }
    }
}
