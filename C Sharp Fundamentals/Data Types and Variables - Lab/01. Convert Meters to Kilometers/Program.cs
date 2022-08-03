using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            double kilometers = (double)meters / 1000;

            Console.WriteLine($"{kilometers:f2}");
        }
    }
}
