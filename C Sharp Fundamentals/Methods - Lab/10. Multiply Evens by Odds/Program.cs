using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int[] arrNumber = Array.ConvertAll(number.ToString().ToArray(), x => (int)x);

            int evenSum = GetSumOfEvenDigits(sum);
            int oddSum = GetSumOfOddDigits(int[] arrNumber);
            GetMultipleOfEvenAndOdds(evenSum, oddSum);
        }
        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
        static int GetSumOfEvenDigits(int[] arrNumber)
        {
            int sum = 0;
            for (int i = 0; i < arrNumber.Length; i++)
            {
                if (arrNumber[i] % 2 == 0)
                {
                    sum += arrNumber[i];
                }
            }
            return sum;
        }
        static int GetSumOfOddDigits(int[] arrNumber)
        {
            int sum = 0;
            for (int i = 0; i < arrNumber.Length; i++)
            {
                if (arrNumber[i] % 2 != 0)
                {
                    sum += arrNumber[i];
                }
            }
            return sum;
        }
    }
}
