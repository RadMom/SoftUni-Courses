using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lengtOfSequences = int.Parse(Console.ReadLine());

            string input = "";
            int[] bestDNA = new int[lengtOfSequences];
            int bestDNAindex= 0;
            int bestSequenceSum = 0;
            int bestStartingIndex = 0;
            int counterOnes = 0;
            int counter = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                counter++;

                int[] currentDNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                int currBestSequenceSum = 0;
                int currStartingIndex = 0;
                int currCounterOnes = 0;
                int count = 0;
                bool currIsBetter = false;

                for (int i = 0; i < currentDNA.Length; i++)
                {
                    if (currentDNA[i]==1)
                    {
                        count++;
                        currCounterOnes++;

                        if(count>currBestSequenceSum)
                        {
                            currBestSequenceSum = count;
                            currStartingIndex = i - count;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
                if(currBestSequenceSum>bestSequenceSum)
                {
                    currIsBetter = true;
                }
                if(currBestSequenceSum==bestSequenceSum)
                {
                    if(currStartingIndex<bestStartingIndex)
                    {
                        currIsBetter = true;
                    }
                    else if(currStartingIndex == bestStartingIndex)
                    {
                        if(currCounterOnes>counterOnes)
                        {
                            currIsBetter = true;
                        }
                    }
                }
                if(currIsBetter)
                {
                    bestDNA = currentDNA;
                    bestSequenceSum = currBestSequenceSum;
                    bestDNAindex = counter;
                    counterOnes = currCounterOnes;
                    bestStartingIndex = currStartingIndex;
                }
            }
            Console.WriteLine($"Best DNA sample {bestDNAindex} with sum: {counterOnes}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
