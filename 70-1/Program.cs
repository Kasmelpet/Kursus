using System;

namespace _65_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] salary = { 10000, 20000, 15000, 20000, 30000, 15000 };
            PrintSalary(salary);
            PrintAvgSalary(salary);
            PrintSortedSalary(salary);

        }

        private static void PrintSortedSalary(int[] salary)
        {
            Array.Sort(salary);
            PrintSalary(salary);
        }

        private static void PrintAvgSalary(int[] salary)
        {
            double avg = 0;
            double sum = 0;
            foreach (var item in salary)
            {
                sum += item;
            }
            avg = sum / salary.Length;
            Console.WriteLine(avg.ToString("N2"));
        }

        private static void PrintSalary(int[] salary)
        {
            foreach (var item in salary)
            {
                Console.WriteLine(item);
            }
        }
    }
}
