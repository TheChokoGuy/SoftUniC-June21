using System;

namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double count = double.Parse(Console.ReadLine());

            if(product == "coffee")
            {
                if(city == "Sofia")
                {
                    Console.WriteLine(0.5 * count);
                }
                else if(city == "Plovdiv")
                {
                    Console.WriteLine(0.4 * count);
                }
                else if(city == "Varna")
                {
                    Console.WriteLine(0.45 * count);
                }
            }
            else if(product == "water")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(0.8 * count);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(0.7 * count);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(0.7 * count);
                }
            }
            else if(product == "beer")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(1.2 * count);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(1.15 * count);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(1.1 * count);
                }
            }
            else if(product == "sweets")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(1.45 * count);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(1.3 * count);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(1.35 * count);
                }
            }
            else if(product == "peanuts")
            {
                if (city == "Sofia")
                {
                    Console.WriteLine(1.6 * count);
                }
                else if (city == "Plovdiv")
                {
                    Console.WriteLine(1.5 * count);
                }
                else if (city == "Varna")
                {
                    Console.WriteLine(1.55 * count);
                }
            }
        }
    }
}
