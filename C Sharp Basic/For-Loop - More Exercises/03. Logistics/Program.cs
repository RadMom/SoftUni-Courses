using System;

namespace _03._Logistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargoNumber = int.Parse(Console.ReadLine());

            double totalCargoWeight = 0;
            int bus = 0;
            int truck = 0;
            int train = 0;

            for(int i=1;i<=cargoNumber;i++)
            {
                int cargoWeight = int.Parse(Console.ReadLine());

                if (cargoWeight<=3)
                {
                    bus+=cargoWeight;
                    totalCargoWeight += cargoWeight;
                }
                else if (cargoWeight>=4 && cargoWeight<=11)
                {
                    truck+=cargoWeight;
                    totalCargoWeight += cargoWeight;
                }
                else if (cargoWeight>=12)
                {
                    train+=cargoWeight;
                    totalCargoWeight += cargoWeight;
                }
            }
            Console.WriteLine($"{(bus*200+truck*175+train*120)/totalCargoWeight:f2}");
            Console.WriteLine($"{bus/totalCargoWeight*100:f2}%");
            Console.WriteLine($"{truck/ totalCargoWeight * 100:f2}%");
            Console.WriteLine($"{train/ totalCargoWeight * 100:f2}%");
        }
    }
}
