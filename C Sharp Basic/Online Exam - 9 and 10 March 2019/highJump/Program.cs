using System;

namespace highJump
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int jumpTarget = int.Parse(Console.ReadLine());

            int startingTarget = jumpTarget - 30;
            int counter = 0;
            int failedCounter = 0;

            while (true)
            {
                int jump = int.Parse(Console.ReadLine());
                counter++;

                if (startingTarget >= jumpTarget)
                {
                    if (jump > jumpTarget)
                    {
                        Console.WriteLine($"Tihomir succeeded, he jumped over" +
                        $" {jumpTarget}cm after {counter} jumps.");
                        break;
                    }
                }
                if (jump > startingTarget)
                {
                    startingTarget += 5;
                    failedCounter = 0;
                }

                else
                {
                    failedCounter++;
                }
                if (failedCounter > 2)
                {
                    Console.WriteLine($"Tihomir failed at {startingTarget}cm " +
                        $"after {counter} jumps.");
                    break;
                }
            }
        }
    }
}
