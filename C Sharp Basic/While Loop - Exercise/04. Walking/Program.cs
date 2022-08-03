using System;

namespace _04._Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stepsGoal = 10000;
            int stepsCounter = 0;
            
            while(stepsCounter < stepsGoal)
            {
                string steps = Console.ReadLine();

                if(steps!="Going home")
                {
                    stepsCounter += int.Parse(steps);
                }
                else
                {
                    steps = Console.ReadLine();
                    stepsCounter += int.Parse(steps);
                    break;
                }
            }
            if(stepsCounter<stepsGoal)
            {
                Console.WriteLine($"{stepsGoal-stepsCounter} more steps to reach goal.");
            }
            else
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{stepsCounter - stepsGoal} steps over the goal!");
            }
        }
    }
}
