using System;

namespace _01._Agency_Profit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int adults = int.Parse(Console.ReadLine());
            int kids = int.Parse(Console.ReadLine());
            double adultsTicketPrice = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double totalAdults = (adultsTicketPrice * adults) + (adults * tax);
            double totalKids = (adultsTicketPrice * 0.3) * kids + (kids * tax);
            double totalProfit = 0.2 * (totalAdults + totalKids);

            Console.WriteLine($"The profit of your agency from {companyName} " +
                $"tickets is {totalProfit:f2} lv.");
        }
    }
}
