using System;

namespace SumOfTwoNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int comNum = 0;
            bool isCombinationFound = false;

            for(int i = start; i <= end; i++)
            {
                for(int i2 = start; i2 <= end; i2++)
                {
                    if(i + i2 == magicNum)
                    {
                        Console.WriteLine($"Combination N:{comNum+1} ({i} + {i2} = {magicNum})");
                        isCombinationFound = true;
                        break;
                    }
                    comNum++;
                }
                if(isCombinationFound)
                {
                    break;
                }
            }

            if(isCombinationFound == false)
            {
                Console.WriteLine($"{comNum} combinations - neither equals {magicNum}");
            }
        }
    }
}
