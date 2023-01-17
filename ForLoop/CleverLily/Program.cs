using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double birthdayMoney = 0;
            int toys = 0;

            double totalMoney = 0;
            for(int i = 1; i <= age; i++)
            {
                if(i % 2 == 0)
                {
                    birthdayMoney += 10;
                    totalMoney += birthdayMoney - 1;
                }
                else
                {
                    toys += 1;
                }
            }
            totalMoney += toys * toyPrice;

            if(totalMoney >= washMachinePrice)
            {
                Console.WriteLine($"Yes! {totalMoney - washMachinePrice:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washMachinePrice - totalMoney:f2}");
            }
        }
    }
}
