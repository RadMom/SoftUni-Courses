using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylonInSqM = int.Parse(Console.ReadLine());
            int paintInLitres = int.Parse(Console.ReadLine());
            int thinnerInLitres = int.Parse(Console.ReadLine());
            int hoursToBeDone = int.Parse(Console.ReadLine());

            double naylonTotalAmount = (nylonInSqM + 2) * 1.5;
            double paintTotalAmount = (paintInLitres + (paintInLitres * 0.1)) * 14.50;
            double thinnerTotalAmount = thinnerInLitres * 5.00;
            double plasticBags = 0.40;

            double materialsTotalAmount = naylonTotalAmount + paintTotalAmount + thinnerTotalAmount + plasticBags;
            double paintersTotalAmout = (materialsTotalAmount * 0.3) * hoursToBeDone;
            double totalAmount = materialsTotalAmount + paintersTotalAmout;

            Console.WriteLine(totalAmount);
        }
    }
}
