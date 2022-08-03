using System;

namespace _04._Food_for_Pets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double foodTotal = double.Parse(Console.ReadLine());

            double eatenFoodTotal =0 ;
            double buicuit = 0;
            int dogEatenFood = 0;
            int catEatenFood = 0;

            for (int i = 1; i <= days; i++)
            {
                int dogFoodDay = int.Parse(Console.ReadLine());
                int catFoodDay = int.Parse(Console.ReadLine());

                dogEatenFood += dogFoodDay;
                catEatenFood += catFoodDay;
                eatenFoodTotal += dogFoodDay + catFoodDay;
                if (i % 3 == 0)
                {
                    buicuit += (dogFoodDay + catFoodDay) * 0.1;
                }
            }
            Console.WriteLine($"Total eaten biscuits: {Math.Round(buicuit)}gr.");
            Console.WriteLine($"{(eatenFoodTotal/foodTotal)*100:f2}% of the food has been eaten.");
            Console.WriteLine($"{(dogEatenFood/eatenFoodTotal)*100:f2}% eaten from the dog.");
            Console.WriteLine($"{(catEatenFood / eatenFoodTotal) * 100:f2}% eaten from the cat.");
        }
    }
}
