using System;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int kozunakNum = int.Parse(Console.ReadLine());

            string winner = "";
            int winnerPoints = 0;

            for (int i = 1; i <= kozunakNum; i++)
            {
                string nameOfTheChief = Console.ReadLine();

                int pointsTotal = 0;

                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "Stop")
                    {
                        Console.WriteLine($"{nameOfTheChief} has {pointsTotal} points.");
                        if (pointsTotal > winnerPoints)
                        {
                            winnerPoints = pointsTotal;
                            winner = nameOfTheChief;
                            Console.WriteLine($"{nameOfTheChief} is the new number 1!");
                        }
                            break;
                    }

                    int points = int.Parse(input);

                    pointsTotal += points;
                }
            }
            Console.WriteLine($"{winner} won competition with" +
                $" {winnerPoints} points!");
        }
    }
}
