using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());

            int counter = 0;

            for (int n1 = start; n1 <= stop; n1++)
            {
                for (int n2 = start; n2 <= stop; n2++)
                {
                    counter++;
                    int sum = n1 + n2;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Combination N:{counter}" +
                    $" ({n1} + {n2} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNumber}");
        }
    }
}
