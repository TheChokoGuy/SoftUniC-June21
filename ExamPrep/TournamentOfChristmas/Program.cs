using System;

namespace TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());

            int wins = 0;
            int loses = 0;
            int dayWins = 0;
            int dayLoses = 0;
            double dailyRaisedMoney = 0;
            double raisedMoney = 0;
            string name = Console.ReadLine();
            for(int i = 1; i <= days; i++)
            {
                while(name != "Finish")
                {
                    string result = Console.ReadLine();
                    if(result == "win")
                    {
                        wins++;
                        dayWins++;
                    }
                    else if(result == "lose")
                    {
                        loses++;
                        dayLoses++;
                    }
                    name = Console.ReadLine();
                    
                }
                dailyRaisedMoney = dayWins * 20;
                if(dayWins > dayLoses)
                {
                    dailyRaisedMoney += dailyRaisedMoney * 0.1;
                }
                raisedMoney += dailyRaisedMoney;
                dailyRaisedMoney = 0;
                dayLoses = 0;
                dayWins = 0;
                name = Console.ReadLine();
            }
            if (wins > loses)
            {
                raisedMoney += raisedMoney * 0.2;
                Console.WriteLine($"You won the tournament! Total raised money: {raisedMoney:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {raisedMoney:f2}");
            }
        }
    }
}
