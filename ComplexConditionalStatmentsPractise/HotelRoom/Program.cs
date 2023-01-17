using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0.0;
            double studioPrice = 0.0;

            if (mounth == "May" || mounth == "October")
            {
                apartmentPrice = 65 * nights;
                studioPrice = 50 * nights;
                if(nights > 7 && nights <= 14)
                {
                    studioPrice -= studioPrice * 0.05;
                }
                else if(nights > 14)
                {
                    studioPrice -= studioPrice * 0.3;
                }

            }
            else if (mounth == "June" || mounth == "September")
            {
                studioPrice = 75.2 * nights;
                apartmentPrice = 68.7 * nights;
                if (nights > 14)
                {
                    studioPrice -= studioPrice * 0.2;
                }
            }
            else if (mounth == "July" || mounth == "August")
            {
                studioPrice = 76 * nights;
                apartmentPrice = 77 * nights;
            }

            if(nights > 14)
            {
                apartmentPrice -= apartmentPrice * 0.1;
            }

            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
            
        }
    }
}
