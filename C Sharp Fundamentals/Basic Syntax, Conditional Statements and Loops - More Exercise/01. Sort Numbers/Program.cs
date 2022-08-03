using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int[] numbers = { num1, num2, num3 };
            Array.Sort(numbers);
            Array.Reverse(numbers);
            Array.ForEach(numbers, Console.WriteLine);
        }
    }
}
