using System;

namespace _03._Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double p1Counter = 0;
            double p2Counter = 0;
            double p3Counter = 0;
            double p4Counter = 0;
            double p5Counter = 0;

            for(int i=1;i<=n;i++)
            {
                int curentNum = int.Parse(Console.ReadLine());

                if(curentNum<200)
                {
                    p1Counter++;
                }
                else if(curentNum>=200&&curentNum<400)
                {
                    p2Counter++;
                }
                else if (curentNum >= 400 && curentNum < 600)
                {
                    p3Counter++;
                }
                else if (curentNum >= 600 && curentNum < 800)
                {
                    p4Counter++;
                }
                else if (curentNum >= 800)
                {
                    p5Counter++;
                }
            }
            Console.WriteLine($"{p1Counter/ n * 100:f2}%");
            Console.WriteLine($"{p2Counter/ n * 100:f2}%");
            Console.WriteLine($"{p3Counter/ n * 100:f2}%");
            Console.WriteLine($"{p4Counter/ n * 100:f2}%");
            Console.WriteLine($"{p5Counter/ n * 100:f2}%");
        }
    }
}
