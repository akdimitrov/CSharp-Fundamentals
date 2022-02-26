using System;

namespace T06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialNum = int.Parse(Console.ReadLine());
            int num = initialNum;
            int sum = 0;

            while (num > 0)
            {
                int digit = num % 10;
                int factorial = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factorial *= i;
                }
                sum += factorial;
                num /= 10;
            }

            if (sum == initialNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
