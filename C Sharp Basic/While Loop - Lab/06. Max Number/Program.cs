using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string num =Console.ReadLine();
            int max=int.MinValue ;

            while(num!="Stop")
            {
                int num1 = int.Parse(num);
                if (num1>max)
                {
                    max=num1;
                }
                num = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
