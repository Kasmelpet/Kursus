using System;

namespace _87_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Struct
            Console.WriteLine("Struct:");

            sPerson sp1 = new sPerson();
            sPerson sp2 = new sPerson();

            sp1.Id = 1;
            sp2.Id = 2;

            Console.WriteLine($"Initial - sp1: {sp1.Id.ToString()} - sp2: {sp2.Id.ToString()}");

            sp1 = sp2;
            Console.WriteLine($"sp1 = sp2 - sp1: {sp1.Id.ToString()} - sp2: {sp2.Id.ToString()}");

            sp1.Id = 3;
            Console.WriteLine($"sp1 changed - sp1: {sp1.Id.ToString()} - sp2: {sp2.Id.ToString()}");
            Console.WriteLine();

            Console.WriteLine("Class:");

            cPerson cp1 = new cPerson();
            cPerson cp2 = new cPerson();

            cp1.Id = 1;
            cp2.Id = 2;

            Console.WriteLine($"Initial - cp1: {cp1.Id.ToString()} - cp2: {cp2.Id.ToString()}");

            cp1 = cp2;
            Console.WriteLine($"cp1 = cp2 - cp1: {cp1.Id.ToString()} - cp2: {cp2.Id.ToString()}");

            cp1.Id = 3;
            Console.WriteLine($"cp1 changed - cp1: {cp1.Id.ToString()} - cp2: {cp2.Id.ToString()}");
            Console.WriteLine();

            Console.WriteLine("Class:");
        }
    }

    struct sPerson
    {
        public int Id;
    }

    class cPerson
    {
        public int Id;
    }
}
