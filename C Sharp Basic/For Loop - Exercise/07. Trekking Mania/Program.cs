using System;

namespace _07._Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int groupsNumber = int.Parse(Console.ReadLine());

            double totalPpl = 0;
            int musala = 0;
            int monblan = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everest = 0;
            
            for (int i = 1; i <= groupsNumber; i++)
            {
                int pplPerGroup=int.Parse(Console.ReadLine());

                totalPpl += pplPerGroup;

                if (pplPerGroup<6)
                {
                    musala+=pplPerGroup;
                }
                else if (pplPerGroup >= 6 && pplPerGroup<=12)
                {
                    monblan+=pplPerGroup;
                }
                else if (pplPerGroup>=13 && pplPerGroup<=25)
                {
                    kilimandjaro+=pplPerGroup;
                }
                else if (pplPerGroup >=26 && pplPerGroup<=40)
                {
                    k2+=pplPerGroup;
                }
                else if (pplPerGroup >=41)
                {
                    everest+=pplPerGroup;
                }
            }
            Console.WriteLine($"{((musala/totalPpl) * 100):f2}%");
            Console.WriteLine($"{((monblan/ totalPpl) * 100):f2}%");
            Console.WriteLine($"{((kilimandjaro/ totalPpl) * 100):f2}%");
            Console.WriteLine($"{((k2/ totalPpl) * 100):f2}%");
            Console.WriteLine($"{((everest/ totalPpl) * 100):f2}%");
        }
    }
}
