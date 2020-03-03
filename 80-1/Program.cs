using System;

namespace _80_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            Console.WriteLine($"Default værdi t1: { t1.værdi}");
            t1.Ryst();
            Console.WriteLine($"t1 rystet 1 gang: {t1.værdi}");
            t1.Ryst();
            Console.WriteLine($"t1 rystet 2 gange: {t1.værdi}");

            Terning t2 = new Terning(5);
            Console.WriteLine($"Default værdi t2: {t2.værdi}");
            t2.Ryst();
            Console.WriteLine($"t2 rystet 1 gang: {t2.værdi}");
            t2.Ryst();
            Console.WriteLine($"t2 rystet 2 gange: {t2.værdi}");
            t2.Ryst(true);
            Console.WriteLine($"t2 rystet 3 gange: {t2.værdi}");
            try
            {
                Terning t3 = new Terning(8);
            }
            catch (Exception)
            {
                Console.WriteLine("Denne terning har kun 6 sider...");
            }

            Terning avgTerning1 = new Terning();
            Terning avgTerning2 = new Terning();
            double sum = 0;
            double avg = 0;
            for (int i = 0; i < 100000; i++)
            {
                avgTerning1.Ryst();
                avgTerning2.Ryst();
                sum += avgTerning1.værdi + avgTerning2.værdi;
            }
            avg = sum / 100000;
            Console.WriteLine($"Gennemsnit af 100000 rystning er: {avg.ToString("N2")}");
            Console.WriteLine("Slut");

        }
    }
}
