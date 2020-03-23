using System;
using System.Collections.Generic;
using System.Text;

namespace _80_3
{
    class Cup
    {
        private Terning[] terninger = new Terning[5];

        public Cup()
        {
            // add 5 terninger
            for (int i = 0; i < 5; i++)
                terninger[i] = new Terning();
            Ryst();

        }

        public void Ryst()
        {
            for (int i = 0; i < 5; i++)
                terninger[i].Ryst();
        }

        public void Skriv()
        {
            for (int i = 0; i < 5; i++)
                terninger[i].Skriv();
        }

    }
}
