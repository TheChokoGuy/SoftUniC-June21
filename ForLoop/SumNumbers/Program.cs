﻿using System;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < rows; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
