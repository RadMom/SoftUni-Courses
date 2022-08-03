using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int sum = num * i;
                Console.WriteLine($"{num} X {i} = {sum}");
            }
        }
    }
}
