using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            if(fruit == "banana")
            {
                switch(day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine("{0:f2}", 2.5 *amount);
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine("{0:f2}", 2.7 * amount);
                        break;
                    default:
                        Console.WriteLine("{0:f2}", "error");
                        break;
                }
            }
            else if (fruit == "apple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine("{0:f2}", 1.2 * amount);
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine("{0:f2}", 1.25 * amount);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "orange")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine("{0:f2}", 0.85 * amount);
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine("{0:f2}", 0.9 * amount);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "grapefruit")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine("{0:f2}", 1.45 * amount);
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine("{0:f2}", 1.6 * amount);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "kiwi")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine("{0:f2}", 2.7 * amount);
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine("{0:f2}", 3 * amount);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "pineapple")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine("{0:f2}", 5.5 * amount);
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine("{0:f2}", 5.6 * amount);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (fruit == "grapes")
            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        Console.WriteLine("{0:f2}", 3.85 * amount);
                        break;
                    case "Saturday":
                    case "Sunday":
                        Console.WriteLine("{0:f2}", 4.2 * amount);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
