using System;

namespace _04._Computer_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int computerNum = int.Parse(Console.ReadLine());

            double reiting = 0;
            double sales = 0;

            for (int i = 1; i <= computerNum; i++)
            {
                int selsAndRaiting = int.Parse(Console.ReadLine());

                double raitingCurent = selsAndRaiting % 10;
                int posibleSales = selsAndRaiting / 10;

                reiting += raitingCurent;

                if (raitingCurent == 2)
                {
                    sales += 0;
                }
                else if (raitingCurent == 3)
                {
                    sales += posibleSales * 0.5;
                }
                else if (raitingCurent == 4)
                {
                    sales += posibleSales * 0.7;
                }
                else if (raitingCurent == 5)
                {
                    sales += posibleSales * 0.85;
                }
                else if (raitingCurent == 6)
                {
                    sales += posibleSales;
                }
            }
            Console.WriteLine($"{sales:f2}");
            Console.WriteLine($"{reiting / computerNum:f2}");
        }
    }
}
