using System;

namespace _05._Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine())*100;

            int change = (int)input;
            int coinsCounter = 0;

            while(change > 0)
            {
                if (change >= 200)
                {
                    change-=200;
                }
                else if (change >= 100)
                {
                    change-=100;
                }
                else if (change >= 050)
                {
                    change -= 050;
                }
                else if (change >= 20)
                {
                    change -= 20;
                }
                else if (change >= 10)
                {
                    change -= 10;
                }
                else if (change >= 5)
                {
                    change -= 5;
                }
                else if (change >= 2)
                {
                    change -= 2;
                }
                else if (change >=1)
                {
                    change -= 1;
                }

                coinsCounter++;
            }
            Console.WriteLine(coinsCounter);
        }
    }
}
