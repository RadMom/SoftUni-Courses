using System;

namespace _06._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName=Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int juryNumber = int.Parse(Console.ReadLine());

            for(int i = 0; i < juryNumber; i++)
            {
                string juryName = Console.ReadLine();
                double pointFromJuryName = double.Parse(Console.ReadLine());

                int lenghtJuryName = juryName.Length;
                academyPoints += (lenghtJuryName * pointFromJuryName) / 2;

                if(academyPoints>=1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName}" +
                        $" got a nominee for leading role with {academyPoints:f1}!");
                    break;
                }
            }
            if(academyPoints <1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {(1250.5 - academyPoints):f1} more!");
            }
               
        }
    }
}
