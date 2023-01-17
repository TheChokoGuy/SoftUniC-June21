using System;

namespace TimePlus15Min
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine()) + 15;

            if(minute > 59)
            {
                hour += 1;
                minute = minute - 60;
                if(minute < 10)
                {
                    Console.WriteLine($"{hour}:0{minute}");
                }
                else
                {
                    Console.WriteLine($"{hour}:{minute}");
                }
            }
            else if(minute<10)
            {
                Console.WriteLine($"{hour}:0{minute}");
            }
            
        }
    }
}
