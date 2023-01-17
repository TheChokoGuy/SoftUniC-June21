using System;

namespace TicketForCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double seats = int.Parse(Console.ReadLine());

            double totalTickets = 0;
            double students = 0;
            double standarts = 0;
            double kids = 0;
            double tickets = 0;
            
            for(int i = 1; i <= seats; i++)
            {
                string ticket = Console.ReadLine();
                if(ticket == "standard")
                {
                    standarts++;
                    tickets++;
                    totalTickets++;
                }
                else if (ticket == "student")
                {
                    students++;
                    tickets++;
                    totalTickets++;
                }
                else if (ticket == "kid")
                {
                    kids++;
                    tickets++;
                    totalTickets++;
                }

                if(tickets >= seats || ticket == "End")
                {
                    Console.WriteLine($"{name} - {tickets/seats*100:f2}% full.");
                    tickets = 0;
                    i = 0;
                    name = Console.ReadLine();
                    if (name == "Finish")
                    {
                        break;
                    }
                    seats = int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{students/totalTickets*100:f2}% student tickets.");
            Console.WriteLine($"{standarts / totalTickets*100:f2}% standard tickets.");
            Console.WriteLine($"{kids / totalTickets *100:f2}% kids tickets.");
        }
    }
}
