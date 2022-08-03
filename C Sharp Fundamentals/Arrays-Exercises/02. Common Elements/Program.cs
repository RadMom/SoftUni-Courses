using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arrOne = Console.ReadLine().Split().ToArray();
            string[] arrTwo = Console.ReadLine().Split().ToArray();

            foreach (string currentElement in arrOne)
            {
                for (int i = 0; i < arrTwo.Length; i++)
                {
                    string currentElement2 = arrTwo[i];
                    if (currentElement.Equals(currentElement2))
                    {
                        Console.Write($"{currentElement} ");
                        break;
                    }
                }
            }
        }
    }
}
