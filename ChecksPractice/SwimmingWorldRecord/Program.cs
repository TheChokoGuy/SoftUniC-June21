using System;

namespace SwimmingWorldRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentWorldRecord = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());
            double ivansWorldRecord = meters * secondsPerMeter;
            double waterPusTime = Math.Floor(meters / 15) * 12.5;
            ivansWorldRecord += waterPusTime;

            if(ivansWorldRecord < currentWorldRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivansWorldRecord:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {ivansWorldRecord - currentWorldRecord:f2} seconds slower.");
            }
        }
    }
}
