using System;

namespace T09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                Console.WriteLine(IsPalindrome(input).ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        private static bool IsPalindrome(string num)
        {
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] != num[num.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
