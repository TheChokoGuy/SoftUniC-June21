using System;

namespace YardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());
            double price = meters * 7.61;
            double discount = 0.18 * price;
            double priceWithDiscount = price - discount;
            Console.WriteLine("The final price is: " + priceWithDiscount + " lv.");
            Console.WriteLine("The discount is: " + discount + " lv.");
        }
    }
}
