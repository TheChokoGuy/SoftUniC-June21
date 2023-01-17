using System;

namespace InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double inches = double.Parse(Console.ReadLine());
            double multiplier = 2.54;
            double centimetres = inches * multiplier;
            Console.WriteLine(centimetres);
        }
    }
}
