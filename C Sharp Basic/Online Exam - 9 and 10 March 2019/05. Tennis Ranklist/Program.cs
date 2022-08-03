using System;

namespace _05._Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tournaments = int.Parse(Console.ReadLine());
            int startingPoints = int.Parse(Console.ReadLine());

            double totalPointFromTournaments = 0;
            double winCounter = 0;

            for(int i=1;i<=tournaments;i++)
            {
                string result=Console.ReadLine();

                if(result=="W")
                {
                    winCounter++;
                    totalPointFromTournaments += 2000;
                }
                if (result == "F")
                {
                    totalPointFromTournaments += 1200;
                }
                if (result == "SF")
                {
                    totalPointFromTournaments += 720;
                }
            }
            Console.WriteLine($"Final points: {startingPoints+totalPointFromTournaments}");
            Console.WriteLine($"Average points: {Math.Floor(totalPointFromTournaments/tournaments)}");
            Console.WriteLine($"{winCounter/tournaments*100:f2}%");
        }
    }
}
