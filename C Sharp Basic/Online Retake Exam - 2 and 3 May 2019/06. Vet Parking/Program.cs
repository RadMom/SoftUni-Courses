using System;

namespace _06._Vet_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= days; i++)
            {
                double totalForTheDay = 0;
                for (int j = 1; j <= hours; j++)
                {
                    if (i % 2 == 0 && j % 2 != 0)
                    {
                        totalForTheDay += 2.50;
                    }
                    else if (i % 2 != 0 && j % 2 == 0)
                    {
                        totalForTheDay += 1.25;
                    }
                    else
                    {
                        totalForTheDay += 1;
                    }
                }
                total += totalForTheDay;
                Console.WriteLine($"Day: {i} - {totalForTheDay:f2} leva");
            }
            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
