using System;

namespace _03._Excursion_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double total = 0;

            if (peopleNum <= 5)
            {
                if (season == "spring")
                {
                    total = 50 * peopleNum;
                }
                else if (season == "summer")
                {
                    total = 48.50 * peopleNum * 0.85;
                }
                else if (season == "autumn")
                {
                    total = 60 * peopleNum;
                }
                else if (season == "winter")
                {
                    total = 86 * peopleNum * 1.08;
                }

            }
            else if (peopleNum > 5)
            {
                if (season == "spring")
                {
                    total = 48 * peopleNum;
                }
                else if (season == "summer")
                {
                    total = 45 * peopleNum * 0.85;
                }
                else if (season == "autumn")
                {
                    total = 49.50 * peopleNum;
                }
                else if (season == "winter")
                {
                    total = 85 * peopleNum * 1.08;
                }
            }
            Console.WriteLine($"{total:f2} leva.");
        }
    }
}

