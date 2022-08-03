using System;


namespace _09.Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtInCm = int.Parse(Console.ReadLine());
            int widthInCm = int.Parse(Console.ReadLine());
            int heightInCm = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double percentAsRealNumber = percent / 100;
            int cmToDecimeter = 1 / 10;

            int volumeInLitres = (lenghtInCm * cmToDecimeter) * (widthInCm * cmToDecimeter) *
                (heightInCm * cmToDecimeter);
            double volumeWithoutExtras = volumeInLitres - (volumeInLitres * percentAsRealNumber);
            Console.WriteLine(volumeWithoutExtras);


        }
    }
}
