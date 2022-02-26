using System;

namespace T05.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                int currentNum = i;
                int sum = 0;
                while (currentNum != 0)
                {
                    sum += currentNum % 10;
                    currentNum /= 10;
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
