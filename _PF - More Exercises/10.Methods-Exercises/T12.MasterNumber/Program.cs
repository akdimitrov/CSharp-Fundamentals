using System;
using System.Collections.Generic;

namespace T12.MasterNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMasterNumbers(n);
        }

        private static void PrintMasterNumbers(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                List<int> list = new List<int>();
                bool isPalindrome = true;
                bool isDivisibleBy7 = false;
                bool hasEvenDigit = false;
                int sum = 0;
                int currentNum = i;
                while (currentNum > 0)
                {
                    int currentDigit = currentNum % 10;
                    if (currentDigit % 2 == 0)
                    {
                        hasEvenDigit = true;
                    }
                    list.Add(currentDigit);
                    sum += currentDigit;
                    currentNum /= 10;
                }

                if (sum % 7 == 0)
                {
                    isDivisibleBy7 = true;
                }

                for (int j = 0; j < list.Count / 2; j++)
                {
                    if (list[j] != list[list.Count - 1 - j])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                if (isPalindrome && isDivisibleBy7 && hasEvenDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
