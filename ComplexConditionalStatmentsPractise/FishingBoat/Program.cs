using System;

namespace FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());

            int price = 0;
            double discount = 0;
            double totalPrice;

            switch(season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }

            if(fishermans <= 6)
            {
                discount = price * 0.1;
            }
            else if(fishermans >= 7 && fishermans <= 11)
            {
                discount = price * 0.15;
            }
            else if(fishermans >= 12)
            {
                discount = price * 0.25;
            }

            totalPrice = price - discount;
            if(season != "Autumn")
            {
                if (fishermans % 2 == 0)
                {
                    totalPrice = totalPrice - totalPrice * 0.05;
                }
            }
            

            if(budget >= totalPrice)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
            }
        }
    }
}
