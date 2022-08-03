using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();
            int nRotations = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < nRotations; rotation++)
            {
                string tempElement = arr[0];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = tempElement;
            }
            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
