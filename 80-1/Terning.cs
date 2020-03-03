using System;
using System.Collections.Generic;
using System.Text;

namespace _80_1
{
    public class Terning
    {

        public int værdi;

        public Terning(int værdi = 1)
        {
            if (værdi < 1 || værdi > 6)
                throw new ApplicationException("Forkert værdi");

            this.værdi = værdi;
        }

        public void Ryst()
        {
            Random rnd = new Random();
            værdi = rnd.Next(1, 7);
        }

        public void Ryst(bool Fix)
        {
            værdi = 6;
        }
    }
}
