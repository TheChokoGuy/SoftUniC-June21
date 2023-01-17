using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());

            double p1Nums = 0;
            double p2Nums = 0;
            double p3Nums = 0;

            for (int i = 1; i <= nums; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    p1Nums++;
                }
                if (number % 3 == 0)
                {
                    p2Nums++;
                }
                if (number % 4 == 0)
                { 
                    p3Nums++;
                }
            }

            Console.WriteLine($"{p1Nums / nums * 100:f2}%");
            Console.WriteLine($"{p2Nums / nums * 100:f2}%");
            Console.WriteLine($"{p3Nums / nums * 100:f2}%");
        }
    }
}
