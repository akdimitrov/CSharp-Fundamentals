using System;

namespace T01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int min = Math.Min(num1, Math.Min(num2, num3));
            int max = Math.Max(num1, Math.Max(num2, num3));
            int mid = num1 + num2 + num3 - (min + max);
            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);
        }
    }
}
