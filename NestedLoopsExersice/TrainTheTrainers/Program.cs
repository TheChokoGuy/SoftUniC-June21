using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juries = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();

            double allGrades = 0;
            double sumOfAllGrades = 0;

            double grades = 0;
            double sumOfGrades = 0;
            while(name != "Finish")
            {
                double grade = double.Parse(Console.ReadLine());
                grades++;
                allGrades++;
                sumOfGrades += grade;
                sumOfAllGrades += grade;
                if(grades == juries)
                {
                    Console.WriteLine($"{name} - {sumOfGrades/grades:f2}.");
                    grades = 0;
                    sumOfGrades = 0;
                    name = Console.ReadLine();
                }
            }
            Console.WriteLine($"Student's final assessment is {sumOfAllGrades/allGrades:f2}.");
        }
    }
}
