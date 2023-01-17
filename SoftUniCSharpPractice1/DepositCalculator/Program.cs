using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositAmount = double.Parse(Console.ReadLine());
            double timeAmount = double.Parse(Console.ReadLine());
            double percentAmount = double.Parse(Console.ReadLine()) / 100;
            double amount = depositAmount + timeAmount * ((depositAmount * percentAmount) / 12);
            Console.WriteLine(amount);
            
            
        }
    }
}
