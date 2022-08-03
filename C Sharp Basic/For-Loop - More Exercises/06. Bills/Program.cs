using System;

namespace _06._Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double total = 0;
            double electricityTotal = 0;
            double waterTotal = months*20;
            double internetTotal = months*15;
            double othersTotal = 0;

            for(int i=1;i<=months;i++)
            {
                double electricityForTheMonth = double.Parse(Console.ReadLine());
                electricityTotal += electricityForTheMonth;
                othersTotal += (electricityForTheMonth + 20 + 15) * 1.2;
                total += electricityForTheMonth + (electricityForTheMonth + 20 + 15) * 1.2 + 35;
            }
            Console.WriteLine($"Electricity: {electricityTotal:f2} lv");
            Console.WriteLine($"Water: {waterTotal:f2} lv");
            Console.WriteLine($"Internet: {internetTotal:f2} lv");
            Console.WriteLine($"Other: {othersTotal:f2} lv");
            Console.WriteLine($"Average: {total/months:f2} lv");
        }
    }
}
