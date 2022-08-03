using System;

namespace _05._Game_Of_Intervals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int movesNum = int.Parse(Console.ReadLine());

            double total = 0;
            double Zeroto9 = 0;
            double TenTo20 = 0;
            double TwentyTo30 = 0;
            double ThirtyTo40 = 0;
            double FortyTo50 = 0;
            double invalid = 0;

            for (int i = 1; i <= movesNum; i++)
            {
                int move = int.Parse(Console.ReadLine());
                if (move >= 0 && move <= 9)
                {
                    total += (0.2 * move);
                    Zeroto9++;
                }
                else if (move >= 10 && move <= 19)
                {
                    total +=( 0.3 * move);
                    TenTo20++;
                }
                else if (move >= 20 && move <= 29)
                {
                    total += (0.4 * move);
                    TwentyTo30++;
                }
                else if (move >= 30 && move <= 39)
                {
                    total += 50;
                    ThirtyTo40++;
                }
                else if (move >= 40 && move <= 50)
                {
                    total += 100;
                    FortyTo50++;
                }
                else if (move >= 51 || move < 0)
                {
                    total /= 2;
                    invalid++;
                }
            }
            Console.WriteLine($"{total:f2}");
            Console.WriteLine($"From 0 to 9: {Zeroto9 / movesNum * 100:f2}%");
            Console.WriteLine($"From 10 to 19: {TenTo20 / movesNum * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {TwentyTo30 / movesNum * 100:f2}%");
            Console.WriteLine($"From 30 to 39: {ThirtyTo40 / movesNum * 100:f2}%");
            Console.WriteLine($"From 40 to 50: {FortyTo50 / movesNum * 100:f2}%");
            Console.WriteLine($"Invalid numbers: {invalid / movesNum * 100:f2}%");
        }
    }
}
