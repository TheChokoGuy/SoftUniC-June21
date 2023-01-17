using System;

namespace GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int actors = int.Parse(Console.ReadLine());
            double oneClothingPrice = double.Parse(Console.ReadLine());

            double DecorationPrice = budget * 0.1;
            double totalClothingPrice = actors * oneClothingPrice;
            if(actors>150)
            {
                totalClothingPrice = totalClothingPrice - totalClothingPrice * 0.1;
            }
            double totalPrice = DecorationPrice + totalClothingPrice;
            if(totalPrice > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice - budget:f2} leva more.");
            }
            else if(totalPrice <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalPrice:f2} leva left.");
            }
        }
    }
}
