using System;

namespace _04._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());

            double totalPpl = 0;
            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;

            for (int i = 1; i <= groups; i++)
            {
                int groups1 = int.Parse(Console.ReadLine());
                totalPpl += groups1;

                if(groups1<=5)
                {
                    musala+=groups1;
                }
                else if(groups1>5 && groups1<=12)
                {
                    monblan+=groups1;
                }
                else if(groups1>12 && groups1<=25)
                {
                    kilimandjaro+=groups1;
                }
                else if(groups1>25 && groups1<=40)
                {
                    k2+=groups1;
                }
                else if(groups1>40)
                {
                    everest+=groups1;
                }
                
            }
            Console.WriteLine($"{(musala/totalPpl)*100:f2}%");
            Console.WriteLine($"{(monblan/totalPpl)*100:f2}%");
            Console.WriteLine($"{(kilimandjaro/totalPpl)*100:f2}%");
            Console.WriteLine($"{(k2/totalPpl)*100:f2}%");
            Console.WriteLine($"{(everest/totalPpl)*100:f2}%");
        }
    }
}
