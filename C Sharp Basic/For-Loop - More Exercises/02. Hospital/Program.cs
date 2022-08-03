using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int threatedPatients = 0;
            int unthreatedPatients = 0;
            int doctors = 7;

            for (int i = 1; i <= period; i++)
            {
                int patient = int.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    if(unthreatedPatients>threatedPatients)
                    {
                        doctors++;
                    }
                }
                if(patient >=doctors)
                {
                    unthreatedPatients += patient - doctors;
                    threatedPatients += doctors;
                }
                else
                {
                    threatedPatients += patient;
                }
            }
            Console.WriteLine($"Treated patients: {threatedPatients}.");
            Console.WriteLine($"Untreated patients: {unthreatedPatients}.");
        }
    }
}
