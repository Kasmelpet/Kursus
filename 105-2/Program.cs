using System;

namespace _105_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LudoTerning lt = new LudoTerning();
            for (int i = 0; i < 10; i++)
            {
                lt.Skriv();
                lt.Ryst();
            }

            Terning t = new Terning();
            for (int i = 0; i < 10; i++)
            {
                t.Skriv();
                t.Ryst();
            }
        }
    }

    public class Terning
    {
        private static Random rdr;
        private int vaerdi;

        public Terning()
        {
            Ryst();
        }

        public Terning(int setVaerdi)
        {
            Vaerdi = setVaerdi;
        }

        static Terning()
        {
            rdr = new Random();
        }

        public int Vaerdi
        {
            get { return vaerdi; }
            set { if (value > 6 || value < 1)
                     value = 1;

                vaerdi = value; 
            }
        }

        public void Ryst()
        {
            Vaerdi = rdr.Next(1, 7);
        }

        public virtual void Skriv()
        {
            Console.WriteLine($"[{vaerdi}]");
        }

    }

    public class LudoTerning : Terning
    {
        public bool ErGlobus()
        {
            return (Vaerdi == 3);
        }

        public bool ErStjerne()
        {
            return (Vaerdi == 5);

        }

        public LudoTerning() : base() { }

        public LudoTerning(int setVaerdi) : base(setVaerdi) { }

        public override void Skriv()
        {
            if (ErGlobus())
            {
                Console.WriteLine("[G]");
                return;
            }
            if (ErStjerne())
            {
                Console.WriteLine("[S]");
                return;
            }
            base.Skriv();
        }
    }
}
