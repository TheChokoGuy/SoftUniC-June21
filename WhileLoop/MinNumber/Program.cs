using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int smallestNum = int.MaxValue;
            while (input != "Stop")
            {
                int num = int.Parse(input);
                if (num < smallestNum)
                {
                    smallestNum = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(smallestNum);
        }
    }
}
