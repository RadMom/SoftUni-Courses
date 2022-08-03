using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            double expenses = budget;
            string input = "";

            while ((input = Console.ReadLine()) != "Game Time")
            {
                double price = 0;

                switch (input)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                if (expenses >= price)
                {
                    expenses -= price;
                    Console.WriteLine($"Bought {input}");
                }
                else
                {
                    Console.WriteLine($"Too Expensive");
                }
                if (expenses == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
            }
            Console.WriteLine($"Total spent: ${budget - expenses:f2}. Remaining: ${expenses:f2}");
        }
    }
}
