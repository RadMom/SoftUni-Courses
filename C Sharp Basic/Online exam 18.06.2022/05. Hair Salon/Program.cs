using System;

namespace _05._Hair_Salon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int target = int.Parse(Console.ReadLine());

            int total = 0;
            string service = "";

            while (total < target && (service = Console.ReadLine()) != "closed")
            {
                if (service == "haircut")
                {
                    string model = Console.ReadLine();

                    if (model == "mens")
                    {
                        total += 15;
                    }
                    else if (model == "ladies")
                    {
                        total += 20;
                    }
                    else if (model == "kids")
                    {
                        total += 10;
                    }
                }
                else if (service == "color")
                {
                    string color = Console.ReadLine();

                    if (color == "touch up")
                    {
                        total += 20;
                    }
                    else if (color == "full color")
                    {
                        total += 30;
                    }
                }
            }

            if (total>=target)
            {
                Console.WriteLine("You have reached your target for the day!");
            }
            else
            {
                Console.WriteLine($"Target not reached! You need {target - total}lv. more.");
            }
            Console.WriteLine($"Earned money: {total}lv.");
        }
    }
}

