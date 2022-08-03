using System;

namespace _02._Add_Bags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceLuggage20kg = double.Parse(Console.ReadLine());
            double luggageKg = double.Parse(Console.ReadLine());
            int daysToTrip = int.Parse(Console.ReadLine());
            int luggageNumber = int.Parse(Console.ReadLine());

            double ticketPrice = 0;

            if (luggageKg > 20)
            {
                if (daysToTrip>30)
                {
                    ticketPrice = (priceLuggage20kg * 1.10) * luggageNumber;
                }
                else if (daysToTrip>=7 && daysToTrip<=30)
                {
                    ticketPrice = (priceLuggage20kg * 1.15) * luggageNumber;
                }
                else if (daysToTrip<7)
                {
                    ticketPrice = (priceLuggage20kg * 1.40) * luggageNumber;
                }
            }
            else if (luggageKg >=10 && luggageKg<=20)
            {
                if (daysToTrip > 30)
                {
                    ticketPrice = ((priceLuggage20kg*0.5) * 1.10) * luggageNumber;
                }
                else if (daysToTrip >= 7 && daysToTrip <= 30)
                {
                    ticketPrice = ((priceLuggage20kg*0.5) * 1.15) * luggageNumber;
                }
                else if (daysToTrip < 7)
                {
                    ticketPrice = ((priceLuggage20kg*0.5) * 1.40) * luggageNumber;
                }
            }
            else if (luggageKg <10)
            {
                if (daysToTrip > 30)
                {
                    ticketPrice = ((priceLuggage20kg*0.2) * 1.10) * luggageNumber;
                }
                else if (daysToTrip >= 7 && daysToTrip <= 30)
                {
                    ticketPrice = ((priceLuggage20kg*0.2) * 1.15) * luggageNumber;
                }
                else if (daysToTrip < 7)
                {
                    ticketPrice = ((priceLuggage20kg*0.2) * 1.40) * luggageNumber;
                }
            }
            Console.WriteLine($"The total price of bags is: {ticketPrice:f2} lv. ");

        }
    }
}
