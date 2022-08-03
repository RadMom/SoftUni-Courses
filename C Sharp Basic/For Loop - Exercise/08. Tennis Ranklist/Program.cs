using System;

namespace _08._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournamentNumber = int.Parse(Console.ReadLine());
            int startingPoints=int.Parse(Console.ReadLine());

            double totalPoints = 0;
            double wins = 0;

            for(int i=1; i<=tournamentNumber; i++)
            {
                string pointsFromToirnament=Console.ReadLine();

                if(pointsFromToirnament=="W")
                {
                    totalPoints +=2000;
                    wins++;
                }
                else if (pointsFromToirnament == "F")
                {
                    totalPoints +=1200;
                }
                else if (pointsFromToirnament == "SF")
                {
                    totalPoints += 720;
                }
            }
            Console.WriteLine($"Final points: {(startingPoints + totalPoints)}");
            Console.WriteLine($"Average points: {Math.Floor(totalPoints/tournamentNumber)}");
            Console.WriteLine($"{(wins / tournamentNumber) * 100:f2}%");
        }
    }
}
