using System;

namespace _06._Easter_Decoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int i = 1; i <= clients; i++)
            {
                int produtsCounter = 0;
                double priceTotalForTheClient = 0;

                while (true)
                {
                    string product = Console.ReadLine();

                    if (product == "Finish")
                    {
                        if (produtsCounter % 2 == 0)
                        {
                            priceTotalForTheClient *= 0.8;
                        }
                        totalPrice += priceTotalForTheClient;
                        Console.WriteLine($"You purchased {produtsCounter} " +
                            $"items for {priceTotalForTheClient:f2} leva.");
                        break;
                    }
                    if (product == "basket")
                    {
                        priceTotalForTheClient += 1.50;
                    }
                    if (product == "wreath")
                    {
                        priceTotalForTheClient += 3.8;
                    }
                    if (product == "chocolate bunny")
                    {
                        priceTotalForTheClient += 7;
                    }
                    produtsCounter++;
                }
            }
            Console.WriteLine($"Average bill per client is: " +
                $"{totalPrice / clients:f2} leva.");
        }
    }
}
