using System;

namespace _01._Sum_Seconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secontTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            int totalTime = firstTime + secontTime + thirdTime;

            int minutes = totalTime / 60;
            int seconds = totalTime % 60;

            if (seconds < 10)
            {
                Console.WriteLine($"{minutes}:0{seconds}");
            }
            else
            {
                Console.WriteLine($"{minutes}:{seconds}");
            }


        }
    }
}
