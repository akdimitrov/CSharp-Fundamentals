using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace T02.ConvertBaseNToBase10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int baseN = int.Parse(input[0]);
            string number = input[1];
            BigInteger result = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(number[i].ToString());
                result += digit * BigInteger.Pow(baseN, number.Length - 1 - i);
            }
            Console.WriteLine(result);
        }
    }
}
