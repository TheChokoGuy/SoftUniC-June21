using System;

namespace NewHome
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerKind = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double rosePrice = 5;
            double dahliaPrice = 3.8;
            double tulipPrice = 2.8;
            double narcissusPrice = 3;
            double gladiolPrice = 2.5;

            double totalPrice = 0.0;
            double discount = 0.0;

            switch (flowerKind)
            {
                case "Roses":
                    totalPrice = num * rosePrice;
                    if(num > 80)
                    {
                        discount = totalPrice * 0.1;   
                    }
                    break;
                case "Dahlias":
                    totalPrice = num * dahliaPrice;
                    if(num > 90)
                    {
                        discount = totalPrice * 0.15;
                    }
                    break;
                case "Tulips":
                    totalPrice = num * tulipPrice;
                    if (num > 80)
                    {
                        discount = totalPrice * 0.15;
                    }
                    break;
                case "Narcissus":
                    totalPrice = narcissusPrice * num;
                    if(num < 120)
                    {
                        totalPrice = totalPrice + totalPrice * 0.15;
                    }
                    break;
                case "Gladiolus":
                    totalPrice = num * gladiolPrice;
                    if(num < 80)
                    {
                        totalPrice = totalPrice + totalPrice * 0.2;
                    }
                    break; 
            }
            totalPrice -= discount;

            if(budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {num} {flowerKind} and {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }

        }
    }
}
