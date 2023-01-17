using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int cards = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());

            double totalMoney = nights * 20 * people + cards * 1.60 * people + tickets * 6 * people;
            totalMoney += totalMoney * 0.25;
            Console.WriteLine($"{totalMoney:f2}");
        }
    }
}
