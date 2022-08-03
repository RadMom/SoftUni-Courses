using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                string num = i.ToString();
                int counter = 0;

                for (int j = 0; j < num.Length; j++)
                {
                    int curentDigits = int.Parse(num[j].ToString());
                    if (curentDigits == 0)
                    {
                        break;
                    }
                    if (n % curentDigits == 0)
                    {
                        counter++;
                    }
                }
                if (counter == num.Length)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
