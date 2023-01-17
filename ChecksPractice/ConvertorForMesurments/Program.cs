using System;

namespace ConvertorForMesurments
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string typeTo = Console.ReadLine();

            if(type == "mm")
            {
                if(typeTo == "m")
                {
                    Console.WriteLine($"{num/1000:f3}");
                }
                else if (typeTo == "cm")
                {
                    Console.WriteLine($"{num/10:f3}");
                }
            }
            else if(type == "cm")
            {
                if(typeTo == "mm")
                {
                    Console.WriteLine($"{num * 10:f3}");
                }
                else if(typeTo == "m")
                {
                    Console.WriteLine($"{num/100:f3}");
                }
            }
            else if(type == "m")
            {
                if(typeTo == "mm")
                {
                    Console.WriteLine($"{num*1000:f3}");
                }
                else if(typeTo == "cm")
                {
                    Console.WriteLine($"{num*100:f3}");
                }
            }
        }
    }
}
