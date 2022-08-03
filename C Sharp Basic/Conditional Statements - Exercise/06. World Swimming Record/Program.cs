using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double timeInSecondsPerOneMeter= double.Parse(Console.ReadLine());

            double timeForDistance = distanceInMetres * timeInSecondsPerOneMeter;

            double timesDelayed = Math.Floor(distanceInMetres / 15);

            double delayTime = timesDelayed * 12.5;

            double totalTime = timeForDistance + delayTime;

            bool newRecord = record > totalTime;

            if (newRecord)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else
            { 
                double neededSeconds = totalTime-record;
                Console.WriteLine($"No, he failed! He was {neededSeconds:f2} seconds slower.");
            }
        }
    }
}
