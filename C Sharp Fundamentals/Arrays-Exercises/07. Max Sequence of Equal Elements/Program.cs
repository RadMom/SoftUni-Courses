using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestCounter = 1;
            int counter = 1;
            int sequenceNum = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == arr[i])
                {
                    counter++;

                    if (counter > bestCounter)
                    {
                        bestCounter = counter;
                        sequenceNum = arr[i];
                    }
                }
                else
                {
                    counter = 1;
                }
            }
            Console.WriteLine(string.Join(" ", Enumerable.Repeat(sequenceNum, bestCounter)));
        }
    }
}
