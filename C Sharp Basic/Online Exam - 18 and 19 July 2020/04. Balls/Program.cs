using System;

namespace _04._Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberBalls = int.Parse(Console.ReadLine());

            int totalPoints = 0;
            int redBalls = 0;
            int orangeBalls = 0;
            int yellowBalls = 0;
            int whiteBalls = 0;
            int otherCollors = 0;
            int blackBalls = 0;

            for(int i = 1; i <= numberBalls; i++)
            {
                string collor =Console.ReadLine();

                if(collor=="red")
                {
                    totalPoints += 5;
                    redBalls++;
                }
                else if (collor == "orange")
                {
                    totalPoints += 10;
                    orangeBalls++;
                }
                else if (collor == "yellow")
                {
                    totalPoints += 15;
                    yellowBalls++;
                }
                else if (collor == "white")
                {
                    totalPoints += 20;
                    whiteBalls++;
                }
                else if (collor == "black")
                {
                    totalPoints /= 2;
                    blackBalls++;
                }
                else
                {
                    totalPoints = totalPoints;
                    otherCollors++;
                }
            }
            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Red balls: {redBalls}");
            Console.WriteLine($"Orange balls: {orangeBalls}");
            Console.WriteLine($"Yellow balls: {yellowBalls}");
            Console.WriteLine($"White balls: {whiteBalls}");
            Console.WriteLine($"Other colors picked: {otherCollors}");
            Console.WriteLine($"Divides from black balls:" +
                $" {blackBalls}");
        }
    }
}
