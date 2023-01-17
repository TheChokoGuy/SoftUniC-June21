using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());

            double gradeSum = 0;

            double between1 = 0;
            double between2 = 0;
            double between3 = 0;
            double between4 = 0;

            for(int i = 1; i <= students; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                gradeSum += grade;

                if(grade >= 5.00)
                {
                    between1++;
                }
                else if(grade >= 4 && grade <= 4.99)
                {
                    between2++;
                }
                else if (grade >= 3 && grade <= 3.99)
                {
                    between3++;
                }
                else if (grade < 3)
                {
                    between4++;
                }
            }

            Console.WriteLine($"Top students: {between1/students*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {between2/students*100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {between3/students*100:f2}%");
            Console.WriteLine($"Fail: {between4/students*100:f2}%");
            Console.WriteLine($"Average: {gradeSum/students:f2}");
        }
    }
}
