﻿using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int fNum = int.Parse(Console.ReadLine());

            int sum = 0;
            while(sum < fNum)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine($"{sum}");
        }
    }
}
