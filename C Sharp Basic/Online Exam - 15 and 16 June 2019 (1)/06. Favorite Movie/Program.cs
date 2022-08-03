using System;

namespace _06._Favorite_Movie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = "";
            int counter = 0;

            double totalPoints = double.MinValue;
            string bestMovie = "";

            while ((movieName = Console.ReadLine()) != "STOP")
            {
                counter++;

                int total = 0;
                
                for (int i = 0; i < movieName.Length; i++)
                {
                    char charecter = movieName.ToCharArray()[i];
                    int accii = (int)charecter;
                    total += accii;
                    int lenght=movieName.Length;
                    if (charecter >= 'a' && charecter <= 'z')
                    {
                        total -= 2 * lenght;
                    }
                    else if (charecter >= 'A' && charecter <= 'Z')
                    {
                        total -= lenght;
                    }
                }
                if(total>=totalPoints)
                {
                    totalPoints = total;
                    bestMovie = movieName;
                }
                if(counter==7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
            }
            Console.WriteLine($"The best movie for you is {bestMovie}" +
                $" with {totalPoints} ASCII sum.");
        }
    }
}
