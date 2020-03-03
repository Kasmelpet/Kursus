using System;

namespace _65_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Hvad er dit fulde navn?");
                string fuldeNavn = Console.ReadLine();
                Console.WriteLine($"Hej med dig: {SmartToUpper(fuldeNavn)}");

                //Console.WriteLine($"Jeg hedder: {SmartToUpper(null)}");
                Console.WriteLine($"Jeg hedder: {SmartToUpper("computer")}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Der er sket en lille fejl: {ex.Message}");
            }
            
        }

        static string SmartToUpper(string tekst)
        {
            if (tekst is null)
            {
                throw new ApplicationException("Tekst må ikke være null");
            }
            if (tekst == "")
            {
                throw new ApplicationException("Tekst må ikke være tom");
            }
            tekst = tekst.ToLower();
            tekst = tekst.Substring(0, 1).ToUpper() + tekst.Substring(1);
            return tekst;
        }
    }
}
