using System;

namespace _04._Darts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nameOfThePlayer = Console.ReadLine();

            int shotsCounter = 0;
            int badShotsCounter = 0;
            int startingPoints = 301;

            while (true)
            {
                string multiplier = Console.ReadLine();

                if (multiplier == "Retire")
                {
                    Console.WriteLine($"{nameOfThePlayer} retired after " +
                        $"{badShotsCounter} unsuccessful shots.");
                    break;
                }

                int shot = int.Parse(Console.ReadLine());
                int pointFromShot = 0;

                shotsCounter++;

                if (multiplier == "Single")
                {
                    pointFromShot += shot;
                }
                else if (multiplier == "Double")
                {
                    pointFromShot += 2 * shot;
                }
                else if (multiplier == "Triple")
                {
                    pointFromShot += 3 * shot;
                }

                startingPoints -= pointFromShot;

                if (startingPoints == 0)
                {
                    Console.WriteLine($"{nameOfThePlayer}" +
                        $" won the leg with {shotsCounter - badShotsCounter} shots.");
                    break;
                }
                else if (startingPoints < 0)
                {
                    startingPoints += pointFromShot;
                    badShotsCounter++;
                }
            }
        }
    }
}
