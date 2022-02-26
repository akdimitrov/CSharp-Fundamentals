using System;
using System.Text;

namespace T07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string repeatedString = RepeatString(input, n);
            Console.WriteLine(repeatedString);
        }

        private static string RepeatString(string input, int n)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                result.Append(input);
            }
            return result.ToString();
        }
    }
}
