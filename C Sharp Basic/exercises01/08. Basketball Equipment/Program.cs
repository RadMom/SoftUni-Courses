using System;

namespace _08.Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int taxPerYear = int.Parse(Console.ReadLine());

            double basketballSneakers = taxPerYear - (0.4 * taxPerYear);
            double basketballKit = basketballSneakers - (basketballSneakers * 0.2);
            double basketballBall = basketballKit * 0.25;
            double basketballaccessories = basketballBall * 0.2;

            double totalAmount = taxPerYear + basketballSneakers + basketballKit + basketballBall + basketballaccessories;

            Console.WriteLine(totalAmount);
        }
    }
}
