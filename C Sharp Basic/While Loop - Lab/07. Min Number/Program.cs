using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();

            int min = int.MaxValue;

            while(num!="Stop")
            {
                int num1=int.Parse(num);
                if(num1<min)
                {
                    min = num1;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
