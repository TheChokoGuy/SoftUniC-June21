﻿using System;

namespace TableForMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            for(int n1 = 1; n1 <= 10; n1++)
            {
                for(int n2 = 1; n2 <= 10; n2++)
                {
                    int product = n1 * n2;
                    Console.WriteLine($"{n1} * {n2} = {product}");
                }
            }
        }
    }
}
