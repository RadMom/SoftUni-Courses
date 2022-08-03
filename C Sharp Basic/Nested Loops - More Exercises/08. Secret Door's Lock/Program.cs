using System;

namespace _08._Secret_Door_s_Lock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hundreds = int.Parse(Console.ReadLine());
            int decimals = int.Parse(Console.ReadLine());
            int units = int.Parse(Console.ReadLine());

            for(int h=2;h<=hundreds;h+=2)
            {
                for (int d = 1; d <= decimals; d++) 
                {
                    for(int u=2;u<=units;u+=2)
                    {
                        if(d==2 || d==3 || d==5 || d==7)
                        {
                            Console.WriteLine(h + " " + d + " " + u);
                        }
                    }
                }
            }
        }
    }
}
