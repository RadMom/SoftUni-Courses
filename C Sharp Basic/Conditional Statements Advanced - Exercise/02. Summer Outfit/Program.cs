using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string timeOfTheDay=Console.ReadLine();

            string outfit = "";
            string shoes = "";

            if (timeOfTheDay == "Evening")
            {
                outfit = "Shirt";
                shoes = "Moccasins";
            }
            else if (timeOfTheDay == "Afternoon")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                if (degrees > 18 && degrees <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                if (degrees >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }
            else if (timeOfTheDay == "Morning")
            {
                if (degrees >= 10 && degrees <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                if (degrees > 18 && degrees <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                if (degrees >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
