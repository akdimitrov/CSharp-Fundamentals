using System;

namespace T10.RageExpenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double dispalyPrice = double.Parse(Console.ReadLine());

            double total = lostGames / 2 * headsetPrice + lostGames / 3 * mousePrice + lostGames / 6 * keyboardPrice + lostGames / 12 * dispalyPrice;

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
