using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int biggestNum = int.MinValue;
            while(input != "Stop")
            {
                int num = int.Parse(input);
                if(num > biggestNum)
                {
                    biggestNum = num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(biggestNum);
        }
    }
}
