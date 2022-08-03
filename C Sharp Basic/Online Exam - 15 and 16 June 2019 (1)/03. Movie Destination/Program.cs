using System;

namespace _03._Movie_Destination
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double total = 0;

            if (destination == "Dubai")
            {
                if (season == "Winter")
                {
                    total += 45000 * days * 0.7;
                }
                else if (season == "Summer")
                {
                    total += 40000 * days * 0.7;
                }
            }
            else if (destination == "Sofia")
            {
                if (season == "Winter")
                {
                    total += 17000 * days * 1.25;
                }
                else if (season == "Summer")
                {
                    total += 12500 * days * 1.25;
                }
            }
            else if (destination == "London")
            {
                if (season == "Winter")
                {
                    total += 24000 * days;
                }
                else if (season == "Summer")
                {
                    total += 20250 * days;
                }
            }
            if(total<=budget)
            {
                Console.WriteLine($"The budget for the movie is enough! We have" +
                    $" {budget-total:f2} leva left!");
            }
            else 
            {
                Console.WriteLine($"The director needs {total - budget:f2} leva more!");
            }
        }
    }
}
