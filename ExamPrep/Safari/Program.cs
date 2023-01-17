using System;

namespace Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double moneyNeeded = 100 + fuel * 2.1;

            if(day == "Saturday")
            {
                moneyNeeded -= moneyNeeded * 0.1;
            }
            else if(day == "Sunday")
            {
                moneyNeeded -= moneyNeeded * 0.2;
            }

            if(budget >= moneyNeeded)
            {
                Console.WriteLine($"Safari time! Money left: {budget - moneyNeeded:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {moneyNeeded - budget:f2} lv.");
            }
        }
    }
}
