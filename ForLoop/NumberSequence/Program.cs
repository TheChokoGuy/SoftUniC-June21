﻿using System;

namespace NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int minNum = int.MaxValue;
            int maxNum = int.MinValue;

            for(int i = 0; i < nums; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number < minNum)
                {
                    minNum = number;
                }

                if(number > maxNum)
                {
                    maxNum = number;
                }
            }

            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");
        }
    }
}
