using System;

namespace _01._Movie_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            int tickets = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            int percentFotTheCinema = int.Parse(Console.ReadLine());

            
            double total = days * tickets * ticketPrice * (100 - percentFotTheCinema) / 100;

            Console.WriteLine($"The profit from the movie {movie} is {total:f2} lv.");

        }
    }
}
