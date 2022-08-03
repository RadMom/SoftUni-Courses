using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            var sum = 0;

            for (int i = 1; i <= number * 2; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
