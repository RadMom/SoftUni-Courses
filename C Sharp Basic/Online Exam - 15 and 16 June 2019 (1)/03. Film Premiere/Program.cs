using System;

namespace _03._Film_Premiere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            string moviePack = Console.ReadLine();
            int ticketsNum = int.Parse(Console.ReadLine());
            double total = 0;
            
            if (movie == "John Wick")
            {
                if (moviePack == "Drink")
                {
                    total += 12 * ticketsNum;
                }
                else if (moviePack == "Popcorn")
                {
                    total += 15 * ticketsNum;
                }
                else if (moviePack == "Menu")
                {
                    total += 19 * ticketsNum;
                }
            }
            if (movie == "Star Wars")
            {
                if (moviePack == "Drink")
                {
                    total += 18 * ticketsNum;
                }
                else if (moviePack == "Popcorn")
                {
                    total += 25 * ticketsNum;
                }
                else if (moviePack == "Menu")
                {
                    total += 30 * ticketsNum;
                }
                if (ticketsNum >= 4)
                {
                    total *= 0.7;
                }
            }
            if (movie == "Jumanji")
            {
                if (moviePack == "Drink")
                {
                    total += 9 * ticketsNum;
                }
                else if (moviePack == "Popcorn")
                {
                    total += 11 * ticketsNum;
                }
                else if (moviePack == "Menu")
                {
                    total += 14 * ticketsNum;
                }
                if (ticketsNum == 2)
                {
                    total *= 0.85;
                }
            }
            Console.WriteLine($"Your bill is {total:f2} leva.");
        }
    }
}
