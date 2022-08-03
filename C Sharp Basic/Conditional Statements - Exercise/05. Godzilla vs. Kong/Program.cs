using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budgetForTheMovie = double.Parse(Console.ReadLine());
            int statistNumber=int.Parse(Console.ReadLine());
            double priceClothingPerStatist= double.Parse(Console.ReadLine());

            double decorPrice = 0.1 * budgetForTheMovie;
            double totalForAll = decorPrice + statistNumber * priceClothingPerStatist;

            if (statistNumber > 150)
            {
                totalForAll = decorPrice + (priceClothingPerStatist * statistNumber - (priceClothingPerStatist * statistNumber * 0.1));
            }
            if (budgetForTheMovie < totalForAll)
            {
                    double moreMoneyNeede = totalForAll - budgetForTheMovie;

                    Console.WriteLine("Not enough money!");
                    Console.WriteLine($"Wingard needs { moreMoneyNeede:f2} leva more.");

            }
            else
            {
                    double moneyLeft = budgetForTheMovie - totalForAll;

                    Console.WriteLine("Action!");
                    Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }
                                       
                           
        }
    }
}
