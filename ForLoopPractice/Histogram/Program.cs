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
            double p4Nums = 0;
            double p5Nums = 0;

            for(int i = 1; i <= nums; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if(number < 200)
                {
                    p1Nums++;
                }
                else if(number >= 200 && number < 400)
                {
                    p2Nums++;
                }
                else if (number >= 400 && number < 600)
                {
                    p3Nums++;
                }
                else if (number >= 600 && number < 800)
                {
                    p4Nums++;
                }
                else if (number >= 800)
                {
                    p5Nums++;
                }
            }

            Console.WriteLine($"{p1Nums/nums*100:f2}%");
            Console.WriteLine($"{p2Nums/nums*100:f2}%");
            Console.WriteLine($"{p3Nums/nums*100:f2}%");
            Console.WriteLine($"{p4Nums/nums*100:f2}%");
            Console.WriteLine($"{p5Nums/nums*100:f2}%");
        }
    }
}
