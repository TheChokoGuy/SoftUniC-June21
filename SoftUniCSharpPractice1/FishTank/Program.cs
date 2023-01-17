using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine()) * 0.01;
            double v = lenght * width * height;
            double freeSpace = v - (v * percent);
            double neededWater = freeSpace * 0.001;

            Console.WriteLine(neededWater);


        }
    }
}
