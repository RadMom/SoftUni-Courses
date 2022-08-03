using System;

namespace _05._Division_Without_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double counter2 = 0;
            double counter3 = 0;
            double counter4 = 0;

            for (int i = 1; i <= number; i++)
            {
                int curentNum = int.Parse(Console.ReadLine());

                if (curentNum % 2 == 0)
                {
                    counter2++;
                }
                if (curentNum % 3 == 0)
                {
                    counter3++;
                }
                if (curentNum % 4 == 0)
                {
                    counter4++;
                }
            }
            Console.WriteLine($"{counter2/number*100:f2}%");
            Console.WriteLine($"{counter3 / number * 100:f2}%");
            Console.WriteLine($"{counter4 / number * 100:f2}%");
        }
    }
}
