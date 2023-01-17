using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffle = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double cakePrice = cakes * 45 ;
            double wafflePrice = waffle * 5.8;
            double pancakePrice = pancakes * 3.2;

            double price = (cakePrice + wafflePrice + pancakePrice) * workers * days ;
            double discountedPrice = price - price / 8;

            Console.WriteLine(discountedPrice);
        }
    }
}
