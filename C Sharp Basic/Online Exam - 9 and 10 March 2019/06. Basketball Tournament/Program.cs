using System;

namespace _06._Basketball_Tournament
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheTournament = "";

            double totalCounter = 0;
            int winCounter = 0;
            int loseCounter = 0;
            
            while ((nameOfTheTournament = Console.ReadLine()) != "End of tournaments")
            {
                int counter = 0;
                int numberOfMatches = int.Parse(Console.ReadLine());
                for (int i = 1; i <= numberOfMatches; i++)
                {
                    counter++;
                    totalCounter++;

                    int firstTeamPoints = int.Parse(Console.ReadLine());
                    int secondTeamPoints = int.Parse(Console.ReadLine());

                    if (firstTeamPoints > secondTeamPoints)
                    {
                        Console.WriteLine($"Game {counter} of tournament {nameOfTheTournament}" +
                            $": win with {firstTeamPoints - secondTeamPoints} points.");
                        winCounter++;
                    }
                    else if (secondTeamPoints > firstTeamPoints)
                    {
                        Console.WriteLine($"Game {counter} of tournament {nameOfTheTournament}" +
                            $": lost with {secondTeamPoints - firstTeamPoints} points.");
                        loseCounter++;
                    }
                }
            }
            Console.WriteLine($"{winCounter / totalCounter * 100:f2}% matches win");
            Console.WriteLine($"{loseCounter / totalCounter * 100:f2}% matches lost");
        }
    }
}
