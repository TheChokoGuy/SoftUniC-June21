using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int maxNum = int.MinValue;
            int sum = 0;

            for(int i = 0; i < nums; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if(number > maxNum)
                {
                    maxNum = number;
                }
                sum += number;
            }
            if(maxNum == sum - maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - maxNum - maxNum)}");
            }
        }
    }
}
