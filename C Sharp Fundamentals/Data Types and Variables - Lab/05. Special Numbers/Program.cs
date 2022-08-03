using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                int sum = 0;
                int digit = num;
                while (digit > 0)
                {
                    sum += digit % 10;
                    digit /= 10;
                }
                if (sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{num} -> True");
                }
                else
                {
                    Console.WriteLine($"{num} -> False");
                }
            }
        }
    }
}
