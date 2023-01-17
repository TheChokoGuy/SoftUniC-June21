using System;

namespace ExamPrep
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoins = int.Parse(Console.ReadLine());
            double chineseMoney = double.Parse(Console.ReadLine());
            double comission = double.Parse(Console.ReadLine());

            bitcoins = bitcoins * 1168;
            chineseMoney = chineseMoney * 0.15 * 1.76;

            double totalLv = bitcoins + chineseMoney;

            double euro = totalLv / 1.95;
            Console.WriteLine($"{euro - euro * comission / 100:f2}");

        }
    }
}
