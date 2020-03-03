using System;

namespace _45_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fornavn, efternavn, samletNavn, navnLille, navnStor;
            Console.WriteLine("Hvad er dit fornavn?");
            fornavn = Console.ReadLine();
            Console.WriteLine("Hvad er dit efternavn?");
            efternavn = Console.ReadLine();
            
            samletNavn = $"{fornavn} {efternavn}";
            Console.WriteLine(samletNavn);

            navnLille = samletNavn.ToLower();
            navnStor = samletNavn.ToUpper();

            Console.WriteLine(navnLille);
            Console.WriteLine(navnStor);
            Console.WriteLine(WaveCase(samletNavn));
            Console.WriteLine($"{ Bagvendt(fornavn)} { Bagvendt(efternavn)}");

            System.IO.File.WriteAllText(@"c:\temp\test.txt", $"{samletNavn}\r - Lower case\t:\t {navnLille}\r - Upper case\t:\t {navnStor}\r - Wave Case\t:\t {WaveCase(samletNavn)}\r - Bagvendt\t:\t{Bagvendt(fornavn)} {Bagvendt(efternavn)}");
        }

        public static string WaveCase(string Fuldenavn)
        {
            string ccFuldenavn;
            ccFuldenavn = "";
            for (int i = 0; i < Fuldenavn.Length; i++)
            {
                if (i%2==0)
                {
                    ccFuldenavn += Fuldenavn.Substring(i, 1).ToLower();
                }
                else
                {
                    ccFuldenavn += Fuldenavn.Substring(i, 1).ToUpper();
                }
            }
            return ccFuldenavn;
        }

        public static string Bagvendt(string Fuldenavn)
        {
            string bvString;
            bvString = "";

            for (int i = Fuldenavn.Length-1; i >= 0; i--)
            {
                bvString += Fuldenavn.Substring(i, 1);
            }

            return bvString;
         
        }
    }
}
