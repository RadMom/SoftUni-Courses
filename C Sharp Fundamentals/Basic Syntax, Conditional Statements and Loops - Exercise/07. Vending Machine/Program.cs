using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double acumulatedCoins = 0;
            string input = "";

            while ((input = Console.ReadLine()) != "Start")
            {
                double coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    acumulatedCoins += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
            }
            while ((input = Console.ReadLine()) != "End")
            {
                double price = 0;
                switch (input)
                {
                    case "Nuts":
                        price = 2.0;
                        break;
                    case "Water":
                        price = 0.7;
                        break;
                    case "Crisps":
                        price = 1.5;
                        break;
                    case "Soda":
                        price = 0.8;
                        break;
                    case "Coke":
                        price = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        continue;
                }
                if (acumulatedCoins >= price)
                {
                    acumulatedCoins -= price;
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
            }
            Console.WriteLine($"Change: {acumulatedCoins:f2}");
        }
    }
}
