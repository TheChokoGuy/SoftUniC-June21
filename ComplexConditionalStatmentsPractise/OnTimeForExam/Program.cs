using System;

namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int cameOnHour = int.Parse(Console.ReadLine());
            int cameOnMin = int.Parse(Console.ReadLine());

            if(cameOnHour < examHour)
            {
                if(60 - cameOnMin + examMin > 30)
                {
                    if (cameOnMin > examMin)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{60 - cameOnMin + examMin} minutes before the start");
                    }
                }
                if(60 - cameOnMin + examMin < 31)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{60 - cameOnMin + examMin} minutes before the start");
                }
                if(cameOnMin == examMin)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{examHour - cameOnHour}:00 hours before the start");
                }
                if(60 - cameOnMin + examMin > 59)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{examHour - cameOnHour}:{(60 + cameOnMin + examMin)-60} hours before the start");
                }
            }
            else if(cameOnHour == examHour)
            {
                if(cameOnMin<examMin && cameOnMin > examMin - 31)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{60 - cameOnMin + examMin} minutes before the start");
                }
                else if(examMin == cameOnMin)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{60 - cameOnMin + examMin} minutes before the start");
                }
                else if (cameOnMin > examMin)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{cameOnMin - examMin} minutes after the start");
                }
            }

            if(cameOnHour > examHour)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{cameOnHour - examHour}:{60 - cameOnMin + examMin} hours after the start");
            }

            
        }
    }
}
