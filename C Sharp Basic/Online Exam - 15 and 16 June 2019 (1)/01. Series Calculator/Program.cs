using System;

namespace _01._Series_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            int seasons = int.Parse(Console.ReadLine());
            int episodesPerSeason=int.Parse(Console.ReadLine());
            double adsPerEpisode = double.Parse(Console.ReadLine());

            double total = (seasons * episodesPerSeason*adsPerEpisode * 1.20) + (seasons * 10);
            Console.WriteLine($"Total time needed to watch the {movie} series is {Math.Floor(total)} minutes.");
        }
    }
}
