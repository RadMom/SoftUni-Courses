using System;

namespace _05._Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season=Console.ReadLine();

            string destination="";
            string place="";
            double cost=0;

            if (budget<=100)
            {
                destination = "Bulgaria";
                if(season=="summer")
                {
                    place = "Camp";
                    cost = budget * 0.3;
                }
                if(season=="winter")
                {
                    place = "Hotel";
                    cost = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    cost = budget * 0.4;
                }
                if (season == "winter")
                {
                    place = "Hotel";
                    cost = budget * 0.8;
                }
            }
            else if(budget>1000)
            {
                destination = "Europe";
                place = "Hotel";
                cost = budget * 0.9;
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{place} - {cost:f2}");
        }
    }
}
