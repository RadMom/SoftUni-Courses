using System;

namespace _06._Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());

            double total=0;
            if (operation == '+' || operation == '-' || operation == '*')
            {
                if (operation == '+')
                {
                    total = num1 + num2;
                }
                else if (operation == '-')
                {
                    total = num1 - num2;
                }
                else if (operation == '*')
                {
                    total = num1 * num2;
                }
                if (total % 2 == 0)
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {total} - even");
                }
                else
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {total} - odd");
                }

            }
            if (operation == '/')
            {
                total = (double)num1 / num2;

                if (num2 != 0)
                {
                    Console.WriteLine($"{num1} {operation} {num2} = {total:f2}");
                }
                else
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
            }
            else if (operation == '%')
            {
                if (num2 != 0)
                {
                    total = num1 % num2;

                    Console.WriteLine($"{num1} % {num2} = {total}");
                }

                else
                {
                    Console.WriteLine($"Cannot divide {num1} by zero");
                }
            }
                     
        }
    }
}
