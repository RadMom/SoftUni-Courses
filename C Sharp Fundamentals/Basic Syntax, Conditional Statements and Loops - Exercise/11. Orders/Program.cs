using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordersNum = int.Parse(Console.ReadLine());

            double total = 0;

            for (int i = 1; i <= ordersNum; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double totalForThisOrder = (days * capsulesCount) * pricePerCapsule;
                total += totalForThisOrder;
                Console.WriteLine($"The price for the coffee is: ${totalForThisOrder:f2}");
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
