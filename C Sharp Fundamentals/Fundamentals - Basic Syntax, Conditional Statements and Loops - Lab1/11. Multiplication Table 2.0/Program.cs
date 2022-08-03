using System;

namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var integer = int.Parse(Console.ReadLine());
            var multiplier = int.Parse(Console.ReadLine());

            if (multiplier > 10)
            {
                Console.WriteLine($"{integer} X {multiplier} = {integer * multiplier}");
                return;
            }

            for (int i = multiplier; i <= 10; i++)
            {
                int sum = integer * i;
                Console.WriteLine($"{integer} X {i} = {sum}");
            }
        }
    }
}

