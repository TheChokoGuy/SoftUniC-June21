﻿using System;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int combs = 0;

            for(int n1 = 0; n1 <= n; n1++)
            {
                for(int n2 = 0; n2 <= n; n2++)
                {
                    for(int n3 = 0; n3 <= n; n3++)
                    {
                        if(n1 + n2 + n3 == n)
                        {
                            combs += 1;
                        }
                    }
                }
            }

            Console.WriteLine(combs);
        }
    }
}
