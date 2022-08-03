using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfTheWeek = Console.ReadLine();

            double total = 0;

            if (groupType == "Students")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday": total = 8.45 * peopleNum; break;
                    case "Saturday": total = 9.80 * peopleNum; break;
                    case "Sunday": total = 10.46 * peopleNum; break;
                }
            }
            else if (groupType == "Business")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday": total = 10.90 * peopleNum; break;
                    case "Saturday": total = 15.60 * peopleNum; break;
                    case "Sunday": total = 16 * peopleNum; break;
                }
            }
            else if (groupType == "Regular")
            {
                switch (dayOfTheWeek)
                {
                    case "Friday": total = 15 * peopleNum; break;
                    case "Saturday": total = 20 * peopleNum; break;
                    case "Sunday": total = 22.50 * peopleNum; break;
                }
            }
            if (groupType == "Students" && peopleNum >= 30)
            {
                total *= 0.85;
            }
            else if (groupType == "Business" && peopleNum >= 100)
            {
                total -= total / peopleNum * 10;
            }
            else if (groupType == "Regular" && peopleNum >= 10 && peopleNum <= 20)
            {
                total *= 0.95;
            }
            Console.WriteLine($"Total price: {total:f2}");
        }
    }
}
