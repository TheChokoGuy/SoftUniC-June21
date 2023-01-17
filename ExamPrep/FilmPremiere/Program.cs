using System;

namespace FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();
            string packet = Console.ReadLine();
            int tickets = int.Parse(Console.ReadLine());

            double bill = 0;
            if(film == "Star Wars")
            {
                if(tickets >= 4)
                {
                    switch(packet)
                    {
                        case "Drink":
                            bill = tickets * 18;
                            break;
                        case "Popcorn":
                            bill = tickets * 25;
                            break;
                        case "Menu":
                            bill = tickets * 30;
                            break;
                    }
                    bill -= bill * 0.3;
                }
                else
                {
                    switch (packet)
                    {
                        case "Drink":
                            bill = tickets * 18;
                            break;
                        case "Popcorn":
                            bill = tickets * 25;
                            break;
                        case "Menu":
                            bill = tickets * 30;
                            break;
                    }
                }
            }
            else if(film == "Jumanji")
            {
                if (tickets == 2)
                {
                    switch (packet)
                    {
                        case "Drink":
                            bill = tickets * 9;
                            break;
                        case "Popcorn":
                            bill = tickets * 11;
                            break;
                        case "Menu":
                            bill = tickets * 14;
                            break;
                    }
                    bill -= bill * 0.15;
                }
                else
                {
                    switch (packet)
                    {
                        case "Drink":
                            bill = tickets * 9;
                            break;
                        case "Popcorn":
                            bill = tickets * 11;
                            break;
                        case "Menu":
                            bill = tickets * 14;
                            break;
                    }
                }
            }
            else if(film == "John Wick")
            {
                switch(packet)
                {
                    case "Drink":
                        bill = tickets * 12;
                        break;
                    case "Popcorn":
                        bill = tickets * 15;
                        break;
                    case "Menu":
                        bill = tickets * 19;
                        break;
                }
            }
            Console.WriteLine($"Your bill is {bill:f2} leva.");
        }
    }
}
