using System;

namespace _11._Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());

            double total = 0;

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (fruit == "banana")
                {
                    total = amount * 2.50;
                }
                else if (fruit == "apple")
                {
                    total = amount * 1.20;
                }
                else if (fruit == "orange")
                {
                    total = amount * 0.85;
                }
                else if (fruit == "grapefruit")
                {
                    total = amount * 1.45;
                }
                else if (fruit == "kiwi")
                {
                    total = amount * 2.70;
                }
                else if (fruit == "pineapple")
                {
                    total = amount * 5.50;
                }
                else if (fruit == "grapes")
                {
                    total = amount * 3.85;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (day == "Saturday" || day == "Sunday")
            {
                if (fruit == "banana")
                {
                    total = amount * 2.70;
                }
                else if (fruit == "apple")
                {
                    total = amount * 1.25;
                }
                else if (fruit == "orange")
                {
                    total = amount * 0.90;
                }
                else if (fruit == "grapefruit")
                {
                    total = amount * 1.60;
                }
                else if (fruit == "kiwi")
                {
                    total = amount * 3.00;
                }
                else if (fruit == "pineapple")
                {
                    total = amount * 5.60;
                }
                else if (fruit == "grapes")
                {
                    total = amount * 4.20;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            
            if(total > 0)
            {
                Console.WriteLine($"{total:f2}");
            }
        }
    }
}
