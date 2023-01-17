using System;

namespace BirthdayParty
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double cake = rent * 0.20;
            double drinks = cake - 0.45 * cake;
            double animator = rent / 3;
            double payment = rent + cake + drinks + animator;

            Console.WriteLine(payment); 

        }
    }
}
