using System;

namespace T01.SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            PrintSmallestNum(num1, num2, num3);
        }

        private static void PrintSmallestNum(int num1, int num2, int num3)
        {
            int smallest = num1;
            if (num2 < smallest)
            {
                smallest = num2;
            }
            if (num3 < smallest)
            {
                smallest = num3;
            }
            Console.WriteLine(smallest);
        }
    }
}
