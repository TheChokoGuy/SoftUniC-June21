﻿using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numsInOneBlock = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for(int i = 0; i < numsInOneBlock; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum1 += number;
            }
            for (int i = 0; i < numsInOneBlock; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum2 += number;
            }

            if(sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
