using System;
using System.Collections.Generic;

namespace Recurrsion
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Fluffy", "Ball", 10);
            Dog yourDog = new Dog("Mr", "Stringy", 11);

            Console.WriteLine(myDog.dogs);
        }

    }
}