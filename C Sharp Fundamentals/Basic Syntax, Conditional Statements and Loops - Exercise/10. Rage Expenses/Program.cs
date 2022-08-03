using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGameCounter = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadset = lostGameCounter / 2;
            int trashedMouse = lostGameCounter / 3;
            int trashedKeyboard = trashedMouse / 2;
            int trashedDisplay = trashedKeyboard / 2;

            double totalExpenses = trashedHeadset * headsetPrice + trashedMouse * mousePrice +
                trashedKeyboard * keyboardPrice + trashedDisplay * displayPrice;

            Console.WriteLine($"Rage expenses: {totalExpenses:f2} lv.");
        }
    }
}
