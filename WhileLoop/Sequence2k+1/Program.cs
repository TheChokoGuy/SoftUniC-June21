using System;

namespace Sequence2k_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int biggerThanNum = 1;
            while(number >= biggerThanNum)
            {
                Console.WriteLine(biggerThanNum);
                biggerThanNum *= 2;
                biggerThanNum += 1;
            }
        }
    }
}
