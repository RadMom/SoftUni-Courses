using System;
using System.Linq;

namespace _3._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            foreach (double number in numbers)
                Console.WriteLine($"{number} => {Math.Round(number, MidpointRounding.AwayFromZero)}");
        }
    }
}
