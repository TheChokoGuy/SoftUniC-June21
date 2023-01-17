using System;

namespace BraceletStand
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyPerDay = double.Parse(Console.ReadLine());
            double profitPerDay = double.Parse(Console.ReadLine());
            double moneyNeeded = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalMoney = moneyPerDay * 5 + profitPerDay * 5;
            totalMoney -= moneyNeeded;

            if(totalMoney >= giftPrice)
            {
                Console.WriteLine($"Profit: {totalMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {giftPrice - totalMoney:f2} BGN.");
            }
        }
    }
}
