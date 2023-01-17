using System;

namespace PrimeNums
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int primeSum = 0;
            int nonPrimeSum = 0;

            while(input != "stop")
            {
                int num = int.Parse(input);
                if(num < 0)
                {
                    Console.WriteLine($"Number is negative.");
                }
                int count = 0;
                for(int i = 1; i <= num; i++)
                {
                    if(num % i == 0)
                    {
                        count++;
                    }
                }
                if(count == 2)
                {
                    primeSum += num;
                }
                else if(count != 0)
                {
                    nonPrimeSum += num;
                }
                input = Console.ReadLine();
                
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
