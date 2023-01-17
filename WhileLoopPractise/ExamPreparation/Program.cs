using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int grades = 1;
            string problemName = Console.ReadLine();
            string lastProblem = problemName;
            double grade = int.Parse(Console.ReadLine());
            double gradeSum = grade;
            int solvedProblems = 1;
            int timesFailed = 0;
            bool isFailed = false;

            while(timesFailed < badGrades)
            {
                if (timesFailed >= badGrades)
                {
                    isFailed = true;
                    break;
                }
                problemName = Console.ReadLine();
                if(problemName == "Enough")
                {
                    break;
                }
                else
                {
                    lastProblem = problemName;
                }
                grade = int.Parse(Console.ReadLine());
                gradeSum += grade;
                grades++;
                solvedProblems++;
                if(grade <= 5)
                {
                    timesFailed++;
                }
                
            }

            if(isFailed)
            {
                Console.WriteLine($"You need a break, {timesFailed} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeSum/grades:f2}");
                Console.WriteLine($"Number of problems: {solvedProblems}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
