using System;

namespace _04._Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget=int.Parse(Console.ReadLine());
            string season=Console.ReadLine();
            int numberFishermen = int.Parse(Console.ReadLine());

            double cost = 0;

            if(season=="Spring")
            {
                cost = 3000;
                if(numberFishermen<=6)
                {
                    cost *= 0.9;
                }
                if(numberFishermen>6 && numberFishermen<=11)
                {
                    cost *= 0.85;
                }
                if(numberFishermen>12)
                {
                    cost *= 0.75;
                }
            }
            else if (season == "Summer" || season=="Autumn")
            {
                cost = 4200;
                if (numberFishermen <= 6)
                {
                    cost *= 0.9;
                }
                if (numberFishermen > 6 && numberFishermen <= 11)
                {
                    cost *= 0.85;
                }
                if (numberFishermen > 12)
                {
                    cost *= 0.75;
                }
            }
            else if (season == "Winter")
            {
                cost = 2600;
                if (numberFishermen <= 6)
                {
                    cost *= 0.9;
                }
                if (numberFishermen > 6 && numberFishermen <= 11)
                {
                    cost *= 0.85;
                }
                if (numberFishermen > 12)
                {
                    cost *= 0.75;
                }
            }
            if(season!="Autumn")
            {
                if(numberFishermen%2==0)
                {
                    cost *= 0.95;
                }
            }
            if(budget>=cost)
            {
                Console.WriteLine($"Yes! You have {(budget - cost):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(cost-budget):f2} leva.");
            }
        }
    }
}
