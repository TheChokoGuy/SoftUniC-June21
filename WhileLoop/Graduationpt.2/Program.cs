using System;

namespace Graduationpt._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int grades = 0;
            double sumOfGrades = 0;
            int timesFailed = 0;
            while(timesFailed < 2)
            {
                if(grades >= 12)
                {
                    break;
                }
                double grade = double.Parse(Console.ReadLine());
                if(grade < 4.00)
                {
                    timesFailed++;
                }
                grades++;
                sumOfGrades += grade;
                if (timesFailed >= 2)
                {
                    Console.WriteLine($"{name} has been excluded at {grades - 1} grade");
                    break;
                }
            }
            if(timesFailed < 2)
            {
                Console.WriteLine($"{name} graduated. Average grade: {sumOfGrades / grades:f2}");
            }
        }
    }
}
