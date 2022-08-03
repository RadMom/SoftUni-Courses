using System;

namespace _03._Aluminum_Joinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberWindows = int.Parse(Console.ReadLine());
            string size = Console.ReadLine();
            string delivery=Console.ReadLine();

            double total = 0;

            if(numberWindows<10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            if(size== "90X130")
            {
                total = 110 * numberWindows;
                if(numberWindows>30 && numberWindows<=60)
                {
                    total = total * 0.95;
                }
                else if(numberWindows>60)
                {
                    total = total * 0.92;
                }
            }
            else if (size == "100X150")
            {
                total = 140 * numberWindows;
                if (numberWindows>40 &&numberWindows<=80)
                {
                    total = total * 0.94;
                }
                else if (numberWindows>80)
                {
                    total = total * 0.90;
                }
            }
            else if (size == "130X180")
            {
                total = 190 * numberWindows;
                if (numberWindows>20 && numberWindows<=50)
                {
                    total = total * 0.93;
                }
                else if (numberWindows>50)
                {
                    total = total * 0.88;
                }
            }
            else if (size == "200X300")
            {
                total = 250 * numberWindows;
                if (numberWindows>25 && numberWindows<=50)
                {
                    total = total * 0.91;
                }
                else if (numberWindows>50)
                {
                    total = total * 0.86;
                }
            }
            if(delivery== "With delivery")
            {
                total = total + 60;
            }
            else if(delivery== "Without delivery")
            {
                total = total;
            }
            if(numberWindows>99)
            {
                total = total * 0.96;
            }
            Console.WriteLine($"{total:f2} BGN");
        }
    }
}
