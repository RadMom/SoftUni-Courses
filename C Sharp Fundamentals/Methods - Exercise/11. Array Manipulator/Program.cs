using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();

            while (command[0] != "end")
            {
                if (command[0] == "exchange")
                {
                    int index = int.Parse(command[1]);
                    ExchangedArray(arr, index);
                }
                else if (command[0] == "max")
                {
                    MaxIndex(arr, command);
                }
                else if (command[0] == "min")
                {
                    MinIndex(arr, command);
                }
                else if (command[0] == "first")
                {
                    FindFirstEvenOrOdd(arr, command);
                }
                else if (command[0] == "last")
                {
                    FindLastEvenOrOdd(arr, command);
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine($"[{String.Join(", ", arr)}]");
        }

        private static void FindLastEvenOrOdd(int[] arr, string[] command)
        {
            List<int> parts = new List<int>();
            int elements = int.Parse(command[1]);
            int counter = 0;

            if (elements > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (command[2] == "odd")
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 != 0)
                    {
                        parts.Add(arr[i]);
                        counter++;
                    }
                    if (counter >= elements)
                    {
                        break;
                    }
                }
                parts.Reverse();
                Console.WriteLine($"[{String.Join(", ", parts)}]");
            }
            if (command[2] == "even")
            {
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (arr[i] % 2 == 0)
                    {
                        parts.Add(arr[i]);
                        counter++;
                    }
                    if (counter >= elements)
                    {
                        break;
                    }
                }
                parts.Reverse();
                Console.WriteLine($"[{String.Join(", ", parts)}]");
            }
        }

        private static void FindFirstEvenOrOdd(int[] arr, string[] command)
        {
            List<int> parts = new List<int>();
            int elements = int.Parse(command[1]);
            int counter = 0;

            if (elements > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            if (command[2] == "odd")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        parts.Add(arr[i]);
                        counter++;
                    }
                    if (counter >= elements)
                    {
                        break;
                    }
                }
                Console.WriteLine($"[{String.Join(", ", parts)}]");
            }
            if (command[2] == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        parts.Add(arr[i]);
                        counter++;
                    }
                    if (counter >= elements)
                    {
                        break;
                    }
                }
                Console.WriteLine($"[{String.Join(", ", parts)}]");
            }
        }

        private static void MinIndex(int[] arr, string[] command)
        {
            int min = int.MaxValue;
            int index = -1;

            if (command[1] == "odd")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] <= min)
                        {
                            min = arr[i];
                            index = i;
                        }
                    }
                }
            }
            if (command[1] == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] <= min)
                        {
                            min = arr[i];
                            index = i;
                        }
                    }
                }
            }
            if (index >= 0)
            {
                Console.WriteLine(index);
            }
            else if (index < 0)
            {
                Console.WriteLine("No matches");
            }
        }

        private static void MaxIndex(int[] arr, string[] command)
        {
            int max = int.MinValue;
            int index = -1;

            if (command[1] == "odd")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] >= max)
                        {
                            max = arr[i];
                            index = i;
                        }
                    }
                }
            }
            if (command[1] == "even")
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] >= max)
                        {
                            max = arr[i];
                            index = i;
                        }
                    }
                }
            }
            if (index >= 0)
            {
                Console.WriteLine(index);
            }
            else if (index < 0)
            {
                Console.WriteLine("No matches");
            }

        }

        private static int[] ExchangedArray(int[] arr, int splitIndex)
        {
            if (splitIndex >= arr.Length || splitIndex < 0)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {

                for (int rotstion = 0; rotstion <= splitIndex; rotstion++)
                {
                    int firstElement = arr[0];
                    for (int j = 1; j < arr.Length; j++)
                    {
                        arr[j - 1] = arr[j];
                    }
                    arr[arr.Length - 1] = firstElement;
                }
            }
            return arr;
        }
    }
}

