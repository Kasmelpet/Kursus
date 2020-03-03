using System;

namespace _70_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string txt = "3;5;22;1;10;15;5";
            string[] splitTxt = txt.Split(";");
            int sum = 0;

            foreach (var item in splitTxt)
            {
                sum += Convert.ToInt32(item);
            }

            Console.WriteLine(sum);

        }
    }
}
