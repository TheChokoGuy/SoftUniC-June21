using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int lists = int.Parse(Console.ReadLine());
            double listsFor1Hour = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            double hoursPerDay = (lists / listsFor1Hour) / days;

            Console.WriteLine(hoursPerDay);
        }
    }
}
