using System;

namespace _1._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numberOfWagons];

            int sum = 0;

            for (int IndexOfWagons = 0; IndexOfWagons < wagons.Length; IndexOfWagons++)
            {
                wagons[IndexOfWagons] = int.Parse(Console.ReadLine());
                sum += wagons[IndexOfWagons];
            }

            foreach (int wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
