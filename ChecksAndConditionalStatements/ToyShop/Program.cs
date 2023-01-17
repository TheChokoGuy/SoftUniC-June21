using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double tourPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int talkingDolls = int.Parse(Console.ReadLine());
            int teddybears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double wonMoney;

            double puzzlePrice = 2.60;
            double dollPrice = 3;
            double bearPrice = 4.10;
            double minionPrice = 8.20;
            double truckPrice = 2;

            double totalPuzzlePrice = puzzlePrice * puzzles;
            double totalDollsPrice = dollPrice * talkingDolls;
            double totalBearPrice = teddybears * bearPrice;
            double totalMinionPrice = minionPrice * minions;
            double totalTruckPrice = truckPrice * trucks;

            wonMoney = totalBearPrice + totalDollsPrice + totalMinionPrice + totalPuzzlePrice + totalTruckPrice;
            int toys = puzzles + talkingDolls + minions + trucks + teddybears;
            
            if(toys >= 50)
            {
                wonMoney = wonMoney - wonMoney * 0.25;
            }

            wonMoney = wonMoney - wonMoney * 0.10;

            if (wonMoney > tourPrice)
            {
                Console.WriteLine($"Yes! {wonMoney - tourPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {tourPrice - wonMoney:f2} lv needed.");
            }
        }   
    
    }

}       
