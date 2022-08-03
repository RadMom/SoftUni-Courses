using System;

namespace _05._Average_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            double total = 0;
            int counter = 1;
            while (counter <=n)
            {
                double input=double.Parse(Console.ReadLine());
                counter++;
                total += input;
            }
            Console.WriteLine($"{total / n:f2}");
        }
    }
}
