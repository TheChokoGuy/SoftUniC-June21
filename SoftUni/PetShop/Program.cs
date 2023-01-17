using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int oAnimals = int.Parse(Console.ReadLine());
            double moneyDogs = dogs * 2.5;
            double moneyAnimals = oAnimals * 4;
            double money = moneyAnimals + moneyDogs;
            Console.WriteLine(money + " lv.");
        }
    }
}
