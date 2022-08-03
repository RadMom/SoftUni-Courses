using System;

namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double bonus = 0.0;

            if(n <= 100)
            {
                bonus += 5;
            }
            else if(n>100 &&n<=1000)
            {
                bonus += n * 0.20;
            }
            else if(n>1000)
            {
                bonus += n * 0.1;
            }
            if(n%2==0)
            {
                bonus += 1;
            }
            else if(n%10==5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(n+bonus);
        }
    }
}
