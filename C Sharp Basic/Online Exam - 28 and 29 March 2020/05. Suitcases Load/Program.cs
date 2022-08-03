using System;

namespace _05._Suitcases_Load
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double freeVolume = double.Parse(Console.ReadLine());

            int suitcaseCounter = 0;
            double volumeCounter = 0;
            string suitcase = "";

            while (volumeCounter <= freeVolume && (suitcase = Console.ReadLine()) != "End")
            {
                volumeCounter += double.Parse(suitcase);
                if(volumeCounter>=freeVolume)
                {
                    break; 
                }
                suitcaseCounter++;
            }
            if(suitcase=="End")
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            if(volumeCounter>=freeVolume)
            {
                Console.WriteLine("No more space!");
            }
            Console.WriteLine($"Statistic: {suitcaseCounter} suitcases loaded.");
        }
    }
}
