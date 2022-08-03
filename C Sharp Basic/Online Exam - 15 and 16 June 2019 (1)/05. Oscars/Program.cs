using System;

namespace _05._Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfTheStar = Console.ReadLine();
            double startingPoints = double.Parse(Console.ReadLine());
            int juryNumber = int.Parse(Console.ReadLine());

            double totalPoints = startingPoints;

            for (int i = 1; i <= juryNumber; i++)
            {
                string nameOfTheJury = Console.ReadLine();
                double pointsFromTheJury = double.Parse(Console.ReadLine());

                int leght = nameOfTheJury.Length;
                totalPoints += leght * pointsFromTheJury * 0.5;

                if (totalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {nameOfTheStar} " +
                        $"got a nominee for leading role with {totalPoints:f1}!");
                    break;
                }
            }
            if (totalPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {nameOfTheStar} you need {1250.5 - totalPoints:f1} more!");
            }
        }
    }
}
