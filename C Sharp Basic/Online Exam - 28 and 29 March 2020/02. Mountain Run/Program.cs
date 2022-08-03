using System;

namespace _02._Mountain_Run
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInMEtres=double.Parse(Console.ReadLine());
            double timeInSecPer1M=double.Parse(Console.ReadLine());

            double delay = Math.Floor(distanceInMEtres / 50) * 30;
            double totalTime = distanceInMEtres * timeInSecPer1M + delay;

            if (totalTime<recordInSec)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:f2} seconds.");
            }
            else if(totalTime>=recordInSec)
            {
                Console.WriteLine($"No! He was {totalTime-recordInSec:f2} seconds slower.");
            }
        }
    }
}
