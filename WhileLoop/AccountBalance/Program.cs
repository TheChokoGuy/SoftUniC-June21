using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = 0;

            string input = Console.ReadLine();
            while(input != "NoMoreMoney")
            {
                double increase = double.Parse(input);
                if(increase < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                balance += increase;
                Console.WriteLine($"Increase: {increase:f2}");
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {balance:f2}");

        }
    }
}
