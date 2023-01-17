using System;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();
            int lines = int.Parse(Console.ReadLine());
            int colons = int.Parse(Console.ReadLine());

            double totalSeats = lines * colons;
            switch(ticket)
            {
                case "Premiere":
                    Console.WriteLine($"{totalSeats * 12:f2} leva");
                    break;
                case "Normal":
                    Console.WriteLine($"{totalSeats * 7.5:f2} leva");
                    break;
                case "Discount":
                    Console.WriteLine($"{totalSeats * 5:f2} leva");
                    break;
            }
        }
    }
}
