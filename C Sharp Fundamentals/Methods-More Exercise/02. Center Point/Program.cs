using System;

namespace _02._Center_Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());

            HowFarIsThePointAwayFrom0(x1, y1, x2, y2);
        }

        private static void HowFarIsThePointAwayFrom0(int x1, int y1, int x2, int y2)
        {
            double xPointAwayFrom0 = x1 * x1 + y1 * y1;
            double yPointAwayFrom0 = x2 * x2 + y2 * y2;
            double x = Math.Sqrt(xPointAwayFrom0);
            double y = Math.Sqrt(yPointAwayFrom0);

            if (x <= y)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
