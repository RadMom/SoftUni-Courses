using System;

namespace _07._Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month=Console.ReadLine();
            int nightsNumber = int.Parse(Console.ReadLine());

            double totalApartment = 0;
            double totalStudio = 0;

            if (month == "May" || month == "October")
            {
                totalApartment = nightsNumber * 65.0;
                totalStudio = nightsNumber * 50.0;

                if(nightsNumber>7 && nightsNumber<=14)
                {
                    totalStudio *= 0.95;
                }
                else if (nightsNumber>14)
                {
                    totalStudio *= 0.70;
                }
            }
            else if(month=="June"|| month=="September")
            {
                totalApartment = nightsNumber *68.70;
                totalStudio = nightsNumber *75.20;

                if(nightsNumber>14)
                {
                    totalStudio *= 0.80;
                }
            }
            else if (month == "July" || month == "August")
            {
                totalApartment = nightsNumber *77.0;
                totalStudio = nightsNumber *76.0;
            }
            if(nightsNumber>14)
            {
                totalApartment *= 0.90;
            }
            Console.WriteLine($"Apartment: {totalApartment:f2} lv.");
            Console.WriteLine($"Studio: {totalStudio:f2} lv.");
        }
    }
}
