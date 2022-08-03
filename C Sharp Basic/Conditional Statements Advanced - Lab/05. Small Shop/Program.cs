using System;

namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product= Console.ReadLine();
            string town = Console.ReadLine();
            double quantity= double.Parse(Console.ReadLine());

            if (town=="Sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.50 * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.8 * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.2 * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.45 * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.60 * quantity);
                }

            }
            if(town=="Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.40 * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.70 * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.15 * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.30 * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.50 * quantity);
                }
            }
            if(town=="Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.45 * quantity);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.70 * quantity);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.10 * quantity);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.35 * quantity);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.55 * quantity);
                }
            }
                

        }
    }
}
