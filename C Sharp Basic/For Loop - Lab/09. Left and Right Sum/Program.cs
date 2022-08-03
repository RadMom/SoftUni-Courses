using System;

namespace _09._Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = 0;
            int sum2 = 0;

            for(int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum1 += num;
            }
            for(int i=1; i <= n; i++)
            {
                int num =int.Parse(Console.ReadLine());
                sum2 += num;
            }

            if(sum1==sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }
        }
    }
}
