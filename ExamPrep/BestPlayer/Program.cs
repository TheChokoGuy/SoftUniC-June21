using System;

namespace BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int goals = int.Parse(Console.ReadLine());

            int bestScore = int.MinValue;
            string bestPlayer = "";

            while(name != "END")
            {
                if(goals >= 10)
                {
                    bestPlayer = name;
                    bestScore = goals;
                    break;
                }
                if(bestScore < goals)
                {
                    bestScore = goals;
                    bestPlayer = name;
                }
                name = Console.ReadLine();
                if (name == "END")
                {
                    break;
                }
                goals = int.Parse(Console.ReadLine());
            }
            if(bestScore >= 3)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {bestScore} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {bestScore} goals.");
            }
        }
    }
}
