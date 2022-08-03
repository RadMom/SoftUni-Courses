using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCards = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double videoCardsTotal = videoCards * 250;

            double cpuPricePerPeace = videoCardsTotal * 0.35;
            double cpuTotal = cpuPricePerPeace * cpu;

            double ramPricePerPeace = 0.1 * videoCardsTotal;
            double ramTotal = ramPricePerPeace * ram;
            
            double total = videoCardsTotal + cpuTotal + ramTotal;
            
            if (videoCards > cpu)
            {
                double discount = 0.15 * total;
                total -= discount;
            }
            if(budget>=total)
            {
                double remainigBudget = budget - total;
                Console.WriteLine($"You have {remainigBudget:f2} leva left!");
            }
            else
            {
                double neededmoney = total - budget;
                Console.WriteLine($"Not enough money! You need {neededmoney:f2} leva more!");
            }
        }
    }
}
