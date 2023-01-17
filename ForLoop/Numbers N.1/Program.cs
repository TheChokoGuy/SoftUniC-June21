using System;

namespace Numbers_N._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for(int i = 1; num >= i; num--)
            {
                Console.WriteLine(num);
            }
        }
    }
}
