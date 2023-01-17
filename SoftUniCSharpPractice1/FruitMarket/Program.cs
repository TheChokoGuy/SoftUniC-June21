using System;

namespace FruitMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double priceStrawberry = double.Parse(Console.ReadLine());
            double bananaQuantity = double.Parse(Console.ReadLine());
            double orangeQuantity = double.Parse(Console.ReadLine());
            double raspberryQuantity = double.Parse(Console.ReadLine());
            double strawberryQuantity = double.Parse(Console.ReadLine());

            double raspberriesPrice = priceStrawberry / 2;
            double orangePrice = raspberriesPrice * 0.6;
            double bananaPrice = raspberriesPrice * 0.2;

            double totalStrawberryPrice = strawberryQuantity * priceStrawberry;
            double totalOrangePrice = orangeQuantity * orangePrice;
            double totalBananaPrice = bananaQuantity * bananaPrice;
            double totalRaspberryPrice = raspberryQuantity * raspberriesPrice;

            double totalPrice = totalBananaPrice + totalOrangePrice + totalRaspberryPrice + totalStrawberryPrice;

            Console.WriteLine($"{totalPrice:F2}");

            
        }
    }
}
