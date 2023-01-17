using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int nums = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            bool lostSalary = false;

            for(int i = 1; i <= nums; i++)
            {
                string website = Console.ReadLine();

                if(website == "Facebook")
                {
                    salary -= 150;
                }
                else if(website == "Instagram")
                {
                    salary -= 100;
                }
                else if(website == "Reddit")
                {
                    salary -= 50;
                }

                if(salary <= 0)
                {
                    Console.WriteLine($"You have lost your salary.");
                    lostSalary = true;
                    break;
                }
            }

            if(lostSalary == false)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
