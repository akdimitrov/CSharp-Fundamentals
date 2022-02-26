using System;
using System.Linq;
using System.Numerics;

namespace T01.ConvertFromBase10TobaseN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            int baseN = int.Parse(array[0]);
            BigInteger number = BigInteger.Parse(array[1]);
            string result = string.Empty;
            while (number > 0)
            {
                result += number % baseN;
                number /= baseN;
            }

            Console.WriteLine(result.Reverse().ToArray());
        }
    }
}
