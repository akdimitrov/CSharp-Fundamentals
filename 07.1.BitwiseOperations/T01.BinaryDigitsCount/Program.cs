using System;

namespace T01.BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int binaryDigit = int.Parse(Console.ReadLine());
            int count = 0;
            while (num != 0)
            {
                if (num % 2 == binaryDigit)
                {
                    count++;
                }
                num /= 2;
            }

            Console.WriteLine(count);
        }
    }
}