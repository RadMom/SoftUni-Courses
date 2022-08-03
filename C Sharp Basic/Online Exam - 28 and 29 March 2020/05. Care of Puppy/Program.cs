using System;

namespace _05._Care_of_Puppy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int foodInKg = int.Parse(Console.ReadLine()) * 1000;

            int foodCounter = 0;
            string dayFood = "";

            while ((dayFood = Console.ReadLine()) != "Adopted")
            {
                foodCounter += int.Parse(dayFood);
            }
            if (foodCounter <= foodInKg)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInKg - foodCounter} grams.");
            }
            else if(foodCounter>foodInKg)
            {
                Console.WriteLine($"Food is not enough. You need {foodCounter-foodInKg} grams more.");
            }
        }
    }
}
