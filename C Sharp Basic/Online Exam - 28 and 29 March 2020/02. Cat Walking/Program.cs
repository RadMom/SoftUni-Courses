using System;

namespace _02._Cat_Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int walkMinPerDay = int.Parse(Console.ReadLine());
            int walksPerDay = int.Parse(Console.ReadLine());
            int caloriesPerDay = int.Parse(Console.ReadLine());

            double totalWalks = walksPerDay * walkMinPerDay;
            double burnsCalories = totalWalks * 5;

            if (burnsCalories >= ((double)caloriesPerDay / 2))
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day:" +
                    $" {burnsCalories}.");
            }
            else if (burnsCalories < ((double)caloriesPerDay / 2))
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day:" +
                    $" {burnsCalories}.");
            }
        }
    }
}
