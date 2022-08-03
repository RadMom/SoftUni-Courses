using System;

namespace _11._HappyCat_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double total = 0;

            for (int days1 = 1; days1 <= days; days1++)
            {
                double totalForTheDay = 0;
                for (int hours1 = 1; hours1 <= hours; hours1++)
                {
                    if (days1 % 2 == 0 && hours1 % 2 != 0)
                    {
                        totalForTheDay += 2.50;
                    }
                    else if (days1 % 2 != 0 && hours1 % 2 == 0)
                    {
                        totalForTheDay += 1.25;
                    }
                    else
                    {
                        totalForTheDay += 1;
                    }
                }
                total += totalForTheDay;
                Console.WriteLine($"Day: {days1} - {totalForTheDay:f2} leva");
            }
            
            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
