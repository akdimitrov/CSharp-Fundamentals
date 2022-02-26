using System;
using System.Linq;

namespace T03.RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split().Select(double.Parse).ToArray();
            foreach (var num in nums)
            {
                double number = num;
                if (number == 0) number = 0;
                Console.WriteLine($"{number} => {(int)Math.Round(num, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
