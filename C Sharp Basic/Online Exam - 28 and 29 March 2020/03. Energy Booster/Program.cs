using System;

namespace _03._Energy_Booster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string size = Console.ReadLine();
            int amount = int.Parse(Console.ReadLine());

            double total = 0;
            
            if (fruit== "Watermelon")
            {
                if(size== "small")
                {
                    total = 56 * amount*2;
                }
                else if(size=="big")
                {
                    total = 28.70 * amount*5;
                }
            }
            else if (fruit == "Mango")
            {
                if (size == "small")
                {
                    total = 36.66 * amount*2;
                }
                else if (size == "big")
                {
                    total = 19.60 * amount*5;
                }
            }
            else if (fruit == "Pineapple")
            {
                if (size == "small")
                {
                    total = 42.10 * amount*2;
                }
                else if (size == "big")
                {
                    total = 24.80 * amount*5;
                }
            }
            else if (fruit == "Raspberry")
            {
                if (size == "small")
                {
                    total = 20 * amount*2;
                }
                else if (size == "big")
                {
                    total = 15.20 * amount*5;
                }
            }
            if (total>=400 && total<=1000)
            {
                total *= 0.85;
            }
            else if(total>1000)
            {
                total *= 0.50;
            }
            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
