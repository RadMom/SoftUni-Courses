using System;

namespace _04._Tourist_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double total = 0;
            int counter = 0;

            while(budget>=total)
            {
                string product = Console.ReadLine();
                if(product=="Stop")
                {
                    break;
                }
                double productPrice=double.Parse(Console.ReadLine());
                counter++;

                if(counter%3==0)
                {
                    productPrice *= 0.5;
                }
                total += productPrice;
            }
            if(budget>=total)
            {
                Console.WriteLine($"You bought {counter} " +
                    $"products for {total:f2} leva.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money!");
                Console.WriteLine($"You need {total-budget:f2} leva!");
            }
        }
    }
}
