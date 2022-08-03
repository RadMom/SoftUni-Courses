using System;

namespace _02._Report_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());

            int total = 0;
            double cash = 0;
            int cashCounter = 0;
            double card = 0;
            int cardCounter = 0;
            int counter = 0;
            string input = "";

            while(total<sum && (input=Console.ReadLine())!="End")
            {
                counter++;
                if(counter%2==0)
                {
                    if(int.Parse(input)<10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cardCounter++;
                        card += int.Parse(input);
                        total += int.Parse(input);
                    }
                }
                else
                {
                    if (int.Parse(input) > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        Console.WriteLine("Product sold!");
                        cashCounter++;
                        cash += int.Parse(input);
                        total += int.Parse(input);
                    }
                }
            }
            if(input=="End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
            else if(total>=sum)
            {
                Console.WriteLine($"Average CS: {cash / cardCounter:f2}");
                Console.WriteLine($"Average CC: {card / cardCounter:f2}");
            }

        }
    }
}
