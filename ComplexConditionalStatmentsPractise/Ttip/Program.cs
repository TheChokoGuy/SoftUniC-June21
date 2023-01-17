using System;

namespace Ttip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "assign";
            double spend = 0.0;
            string hotelOrCamp = "assign";

            if(budget <= 100)
            {
                destination = "Bulgaria";
                switch (season)
                {
                    case "summer":
                        spend = budget * 0.3;
                        break;
                    case "winter":
                        spend = budget * 0.7;
                        break;
                }
            }
            else if(budget <= 1000)
            {
                destination = "Balkans";
                switch (season)
                {
                    case "summer":
                        spend = budget * 0.4;
                        break;
                    case "winter":
                        spend = budget * 0.8;
                        break;
                }
            }
            else if(budget > 1000)
            {
                destination = "Europe";
                spend = budget * 0.9;
            }
            if(season == "summer")
            {
                hotelOrCamp = "Camp";
            }
            else if(season == "winter")
            {
                hotelOrCamp = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{hotelOrCamp} - {spend:f2}");
        }
    }
}
