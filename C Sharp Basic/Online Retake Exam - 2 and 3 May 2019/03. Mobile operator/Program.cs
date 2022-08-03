using System;

namespace _03._Mobile_operator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string contractLenght = Console.ReadLine();
            string contractPakage = Console.ReadLine();
            string internet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double total = 0;

            if (contractLenght == "one")
            {
                if (contractPakage == "Small")
                {
                    total = 9.98 * months;
                    if (internet == "yes")
                    {
                        total += 5.5 * months;
                    }
                }
                else if (contractPakage == "Middle")
                {
                    total = 18.99 * months;
                    if (internet == "yes")
                    {
                        total += 4.35 * months;
                    }
                }
                else if (contractPakage == "Large")
                {
                    total = 25.98 * months;
                    if (internet == "yes")
                    {
                        total += 4.35 * months;
                    }
                }
                else if (contractPakage == "ExtraLarge")
                {
                    total = 35.99 * months;
                    if (internet == "yes")
                    {
                        total += 3.85 * months;
                    }
                }
            }
            else if (contractLenght == "two")
            {
                if (contractPakage == "Small")
                {
                    total = 8.58 * months * 0.9625;
                    if (internet == "yes")
                    {
                        total += 5.5 * months * 0.9625;
                    }
                }
                else if (contractPakage == "Middle")
                {
                    total = 17.09 * months * 0.9625;
                    if (internet == "yes")
                    {
                        total += 4.35 * months * 0.9625;
                    }
                }
                else if (contractPakage == "Large")
                {
                    total = 23.59 * months * 0.9625;
                    if (internet == "yes")
                    {
                        total += 4.35 * months * 0.9625;
                    }
                }
                else if (contractPakage == "ExtraLarge")
                {
                    total = 31.79 * months * 0.9625;
                    if (internet == "yes")
                    {
                        total += 3.85 * months * 0.9625;
                    }
                }
            }
            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
