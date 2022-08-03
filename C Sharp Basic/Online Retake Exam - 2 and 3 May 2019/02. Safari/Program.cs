using System;

namespace _02._Safari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double neededFuel = double.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            double total = neededFuel * 2.1 + 100;

            if(day=="Saturday")
            {
                total *= 0.9;
            }
            else if(day=="Sunday")
            {
                total *= 0.8;
            }
            if (budget>=total)
            {
                Console.WriteLine($"Safari time! Money left: {budget - total:f2} lv.");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {total-budget:f2} lv.");
            }
        }
    }
}
