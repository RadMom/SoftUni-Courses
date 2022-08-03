using System;

namespace _05._Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int seriesNumber = int.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= seriesNumber; i++)
            {
                string nameOfTheSeries = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());

                if (nameOfTheSeries == "Thrones")
                {
                    total += 0.5 * price;
                }
                else if (nameOfTheSeries == "Lucifer")
                {
                    total += 0.6 * price;
                }
                else if (nameOfTheSeries == "Protector")
                {
                    total += 0.7 * price;
                }
                else if (nameOfTheSeries == "TotalDrama")
                {
                    total += 0.8 * price;
                }
                else if (nameOfTheSeries == "Area")
                {
                    total += 0.9 * price;
                }
                else
                {
                    total += price;
                }
            }
            if(budget>=total)
            {
                Console.WriteLine($"You bought all the series and left with {budget-total:f2} lv.");
            }
            else
            {
                Console.WriteLine($"You need {total-budget:f2} lv. more to buy the series!");
            }
        }
    }
}

