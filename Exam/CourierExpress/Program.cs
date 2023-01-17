using System;

namespace CourierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            double kms = double.Parse(Console.ReadLine());

            double moneyPerKm = 0;
            double moneyPerKg = 0;

            double expressMoneyForKms = moneyPerKg;
            if (weight < 1)
            {
                moneyPerKm = 3;
                moneyPerKg = moneyPerKm * 0.8;
                expressMoneyForKms = moneyPerKm * 0.8;
            }
            else if(weight >= 1 && weight < 10)
            {
                moneyPerKm = 5;
                moneyPerKg = moneyPerKm * 0.4;
                expressMoneyForKms = moneyPerKm * 0.4;
            }
            else if(weight >= 10 && weight < 40)
            {
                moneyPerKm = 10;
                moneyPerKg = moneyPerKm * 0.05;
                expressMoneyForKms = moneyPerKm * 0.05;
            }
            else if (weight >= 40 && weight < 90)
            {
                moneyPerKm = 15;
                moneyPerKg = moneyPerKm * 0.02;
                expressMoneyForKms = moneyPerKm * 0.02;
            }
            else if (weight >= 90 && weight < 150)
            {
                moneyPerKm = 20;
                moneyPerKg = moneyPerKm * 0.01;
                expressMoneyForKms = moneyPerKm * 0.01;
            }

            double moneyForKms = kms * moneyPerKm / 100;

            double moneyForKgs = weight * expressMoneyForKms / 100;
            double totalExpressMoney = kms * moneyForKgs + moneyForKms;
            if(type == "standard")
            {
                Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {moneyForKms:f2} lv.");
            }
            else if(type == "express")
            {
                Console.WriteLine($"The delivery of your shipment with weight of {weight:f3} kg. would cost {totalExpressMoney:f2} lv.");
            }
        }
    }
}
