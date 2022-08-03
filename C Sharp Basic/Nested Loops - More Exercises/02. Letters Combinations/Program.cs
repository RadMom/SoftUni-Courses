using System;

namespace _02._Letters_Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char missThisOne = char.Parse(Console.ReadLine());

            int counter = 0;

            for(int i=a;i<=b;i++)
            {
                for(int i2=a;i2<=b;i2++)
                {
                    for(int i3=a;i3<=b;i3++)
                    {
                        if(i!=missThisOne&&i2!=missThisOne&&i3!=missThisOne)
                        {
                            i = Convert.ToChar(i);
                            i2 = Convert.ToChar(i2);
                            i3 = Convert.ToChar(i3);
                            counter++;
                            Console.Write(i + i2 + i3 + " ");
                        }
                    }
                }
            }
            Console.Write(counter);
        }
    }
}
