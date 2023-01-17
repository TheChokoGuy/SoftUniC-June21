using System;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;

            for(int i = 1; i <= nums; i ++)
            {
                if(i % 2 == 0)
                {
                    int number = int.Parse(Console.ReadLine());
                    sum1 += number;
                }
                else
                {
                    int number = int.Parse(Console.ReadLine());
                    sum2 += number;
                }
            }

            if(sum1 == sum2)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {sum1}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum1 - sum2)}");
            }

        }
    }
}
