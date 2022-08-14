using System;
using System.Linq;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            TopNumber(endNumber);

        }

        private static void TopNumber(int endNumber)
        {
            for (int currNum = 0; currNum < endNumber; currNum++)
            {
                var currNumber = currNum.ToString().Select(x => int.Parse(x.ToString()))
                    .ToArray();
                int sum = 0;
                int oddCounter = 0;
                for (int currDigit = 0; currDigit < currNumber.Length; currDigit++)
                {
                    sum += currNumber[currDigit];
                    if (currNumber[currDigit] % 2 != 0)
                    {
                        oddCounter++;
                    }
                }
                if (oddCounter > 0 && sum % 8 == 0)
                {
                    Console.WriteLine(currNum);
                }
            }
        }
    }
}

