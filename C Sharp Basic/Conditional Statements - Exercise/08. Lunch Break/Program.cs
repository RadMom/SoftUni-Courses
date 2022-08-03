using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name= Console.ReadLine();
            int episodTime = int.Parse(Console.ReadLine());
            int breakTime= int.Parse(Console.ReadLine());

            double lunchTime = 0.125 * breakTime;
            double timeForRest = 0.25 * breakTime;

            double timeUhave = breakTime - lunchTime - timeForRest;

            double timeLeft = timeUhave - episodTime;

            if (timeUhave>=episodTime)
            {
                    Console.WriteLine($"You have enough time to watch {name}" +
                    $" and left with {Math.Ceiling(timeLeft)} minutes free time.");
            }
            else
            {
                double needMoreTime = Math.Ceiling(episodTime - timeUhave);
                Console.WriteLine($"You don't have enough time to watch {name}" +
                    $", you need {needMoreTime} more minutes.");
            }

        }
    }
}
