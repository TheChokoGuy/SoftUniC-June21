using System;

namespace FacesOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if(figure == "square")
            {
                double lenghtOfSide = double.Parse(Console.ReadLine());
                Console.WriteLine($"{lenghtOfSide * lenghtOfSide:f3}");
            }
            else if(figure == "rectangle")
            {
                double lenght = double.Parse(Console.ReadLine());
                double width = double.Parse(Console.ReadLine());

                Console.WriteLine($"{lenght * width:f3}");
            }
            else if(figure == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"{radius*radius*Math.PI:f3}");
            }
            else if(figure == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"{side * height / 2:f3}");
            }
        }
    }
}
