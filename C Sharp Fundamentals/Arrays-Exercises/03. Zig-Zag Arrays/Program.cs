using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            int[] arr1 = new int[nLines];
            int[] arr2 = new int[nLines];

            for (int i = 0; i < nLines; i++)
            {
                int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (i % 2 == 0)
                {
                    arr1[i] = ints[0];
                    arr2[i] = ints[1];
                }
                else
                {
                    arr1[i] = ints[1];
                    arr2[i] = ints[0];
                }
            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ", arr2));
        }
    }
}
