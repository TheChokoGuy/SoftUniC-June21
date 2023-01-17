using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for(int number = 1111; number <= 9999; number++)
            {
                int thousands = number / 1000;
                int hundreds = number / 100 % 10;
                int tens = number / 10 % 10;
                int units = number % 10;

                if(thousands != 0 && n % thousands == 0 && hundreds != 0 && n % hundreds == 0 && tens != 0 && n % tens == 0 && units != 0 && n % units == 0)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
