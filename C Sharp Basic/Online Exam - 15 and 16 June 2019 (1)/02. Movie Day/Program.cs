using System;

namespace _02._Movie_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int timeForPhotos=int.Parse(Console.ReadLine());
            int scenes=int.Parse(Console.ReadLine());
            int timePerScene = int.Parse(Console.ReadLine());

            double total = (0.15 * timeForPhotos) + scenes * timePerScene;
            if(total<=timeForPhotos)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have " +
                    $"{Math.Round(timeForPhotos-total)} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need " +
                    $"{Math.Round(total - timeForPhotos)} minutes.");
            }
        }
    }
}
