using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string grade = Console.ReadLine();

            int nights = days - 1;
            double price;
            double discount;

            double rFOPPrice = 18;
            double apartmentPrice = 25;
            double presidentApartmentPrice = 35;

            double totalPrice = 0;

            if(room == "room for one person")
            {
                price = nights * rFOPPrice;
                if(grade == "positive")
                {
                    Console.WriteLine($"{price + price * 0.25:f2}");
                }
                else if (grade == "negative")
                {
                    Console.WriteLine($"{price - price * 0.1:f2}");
                }
            }
            else if(room == "apartment")
            {
                price = nights * apartmentPrice;
                if(days < 10)
                {
                    discount = price * 0.30;
                    totalPrice = price - discount;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = price * 0.35;
                    totalPrice = price - discount;
                }
                else if (days > 15)
                {
                    discount = price * 0.5;
                    totalPrice = price - discount;
                }
                
                if(grade == "positive")
                {
                    Console.WriteLine($"{totalPrice + totalPrice * 0.25:f2}");
                }
                else if(grade == "negative")
                {
                    Console.WriteLine($"{totalPrice - totalPrice * 0.1:f2}");
                }
            }
            else if(room == "president apartment")
            {
                price = nights * presidentApartmentPrice;
                if (days < 10)
                {
                    discount = price * 0.1;
                    totalPrice = price - discount;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = price * 0.15;
                    totalPrice = price - discount;
                }
                else if (days > 15)
                {
                    discount = price * 0.20;
                    totalPrice = price - discount;
                }

                if (grade == "positive")
                {
                    Console.WriteLine($"{totalPrice + totalPrice * 0.25:f2}");
                }
                else if (grade == "negative")
                {
                    Console.WriteLine($"{totalPrice - totalPrice * 0.1:f2}");
                }
            }
        }
    }
}
