using System;
using System.Linq;
using System.Text;

namespace T05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] digits = Console.ReadLine().ToCharArray()
                .Select(x => int.Parse(x.ToString())).ToArray();
            int multiplier = int.Parse(Console.ReadLine());
            StringBuilder product = new StringBuilder();
            if (multiplier != 0)
            {
                int remainder = 0;
                for (int i = digits.Length - 1; i >= 0; i--)
                {
                    int current = digits[i] * multiplier + remainder;
                    product.Insert(0, current % 10);
                    remainder = current / 10;
                }

                if (remainder > 0)
                {
                    product.Insert(0, remainder);
                }
            }

            Console.WriteLine(multiplier == 0 ? "0" : product.ToString());
        }
    }
}
