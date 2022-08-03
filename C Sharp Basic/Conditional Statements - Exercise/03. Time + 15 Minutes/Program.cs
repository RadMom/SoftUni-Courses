using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int bonus = 15;
            if (minutes + bonus > 59)
            {
                hours += 1;
                minutes = minutes + bonus - 60;
                if (hours > 23)
                {
                    hours = 0;
                }
            }
            else
            {
                minutes=minutes + bonus ;
            }
            Console.WriteLine($"{hours}:{minutes:D2}");
        }
    }
}
