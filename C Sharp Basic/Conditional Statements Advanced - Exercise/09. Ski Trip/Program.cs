using System;

namespace _09._Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string whereWillStay= Console.ReadLine();
            string evaluation=Console.ReadLine();

            int nights = days-1;
            double roomForOnePersonTotal = 18.00*nights;
            double apartmentTotal = 25.00*nights;
            double presidentApartmentTotal = 35.00*nights;
            double total = 0;

            if(whereWillStay=="room for one person")
            {
                total = roomForOnePersonTotal;
            }
            if (whereWillStay == "apartment")
            {
                if (days < 10)
                {
                    total = apartmentTotal * 0.70;
                }
                else if (days >= 10 && days <= 15)
                {
                    total = apartmentTotal * 0.65;
                }
                if (days > 15)
                {
                    total = apartmentTotal * 0.50;
                }
            }
            if (whereWillStay == "president apartment")
            {
                if (days < 10)
                {
                    total = presidentApartmentTotal * 0.90;
                }
                else if (days >= 10 && days <= 15)
                {
                    total = presidentApartmentTotal * 0.85;
                }
                if (days > 15)
                {
                    total = presidentApartmentTotal * 0.80;
                }
            }
            if(evaluation=="positive")
            {
                total *= 1.25;
            }
            else if(evaluation=="negative")
            {
                total *= 0.90;
            }
            Console.WriteLine($"{total:f2}");

        }
    }
}
