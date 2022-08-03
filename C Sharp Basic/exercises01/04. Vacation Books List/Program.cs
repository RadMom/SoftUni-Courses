using System;

namespace _04.Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int daysForReading = int.Parse((Console.ReadLine()));

            int HoursPerDayForReadings = (numberOfPages / pagesPerHour) / daysForReading;

            Console.WriteLine(HoursPerDayForReadings);
        }
    }
}
