using System;

namespace FootballTournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int gamesPlayed = int.Parse(Console.ReadLine());

            int totalPoints = 0;
            int wonGames = 0;
            int draws = 0;
            int losts = 0;

            for(int i = 1; i <= gamesPlayed; i++)
            {
                char result = char.Parse(Console.ReadLine());
                switch(result)
                {
                    case 'W':
                        wonGames += 1;
                        totalPoints += 3;
                        break;
                    case 'D':
                        draws += 1;
                        totalPoints += 1;
                        break;
                    case 'L':
                        losts++;
                        break;
                }
            }

            if(gamesPlayed == 0)
            {
                Console.WriteLine($"{name} hasn't played any games during this season.");
            }
            else
            {
                double winRate = wonGames * 1.0 / gamesPlayed * 100;
                Console.WriteLine($"{name} has won {totalPoints} points during this season.");
                Console.WriteLine($"Total stats:");
                Console.WriteLine($"## W: {wonGames}");
                Console.WriteLine($"## D: {draws}");
                Console.WriteLine($"## L: {losts}");
                Console.WriteLine($"Win rate: {winRate:f2}%");
            }
        }
    }
}
