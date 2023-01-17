using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double size = double.Parse(Console.ReadLine());
            double percent;

            if(city == "Sofia")
            {
                if(size > 0 && size <= 500)
                {
                    percent = 5 * 0.01;
                    Console.WriteLine($"{size * percent:f2}");
                }
                else if (size > 500 && size <= 1000)
                {
                    percent = 7 * 0.01;
                    Console.WriteLine($"{size * percent:f2}");
                }
                else if (size > 1000 && size <= 10000)
                {
                    percent = 8 * 0.01;
                    Console.WriteLine($"{size * percent:f2}");
                }
                else if (size > 10000)
                {
                    percent = 12 * 0.01;
                    Console.WriteLine($"{size * percent:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (city == "Varna")
            {
                if (size > 0 && size <= 500)
                {
                    percent = 4.5 * 0.01;
                    Console.WriteLine($"{size * percent:f2}");
                }
                else if (size > 500 && size <= 1000)
                {
                    percent = 7.5 * 0.01;
                    Console.WriteLine($"{size * percent:f2}");
                }
                else if (size > 1000 && size <= 10000)
                {
                    percent = 10 * 0.01;
                    Console.WriteLine($"{size * percent:f2}");
                }
                else if (size > 10000)
                {
                    percent = 13 * 0.01;
                    Console.WriteLine($"{size * percent:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else if (city == "Plovdiv")
            {
                if (size > 0 && size <= 500)
                {
                    percent = 5.5 * 0.01;
                    Console.WriteLine($"{size * percent:f2}");
                }
                else if (size > 500 && size <= 1000)
                {
                    percent = 8 * 0.01;
                    Console.WriteLine($"{size * percent:f2}");
                }
                else if (size > 1000 && size <= 10000)
                {
                    percent = 12 * 0.01;
                    Console.WriteLine($"{size * percent:f2}");
                }
                else if (size > 10000)
                {
                    percent = 14.5 * 0.01;
                    Console.WriteLine($"{size * percent:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }

            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
