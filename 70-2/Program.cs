using System;

namespace _70_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = "2";
            string[,] Navneliste = new string[4, 2];
            Navneliste[0, 0] = "1";
            Navneliste[0, 1] = "Navn 1";
            Navneliste[1, 0] = "2";
            Navneliste[1, 1] = "Navn 2";
            Navneliste[2, 0] = "3";
            Navneliste[2, 1] = "Navn 3";
            Navneliste[3, 0] = "4";
            Navneliste[3, 1] = "Navn 4";

            string Navn = FindNavn(Navneliste, id);
            Console.WriteLine(Navn);
        }

        private static string FindNavn(string[,] navneliste, string id)
        {
            for (int i = 0; i < navneliste.Length; i++)
            {
                if (navneliste[i, 0] == id)
                    return navneliste[i, 1];
            }
            return "?";
        }
    }
}
