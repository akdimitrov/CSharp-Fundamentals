using System;
using System.Text;

namespace T03.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {

                result.Append(String.Format($"\\u{(int)input[i]:x4}"));
            }
            Console.WriteLine(result);
        }
    }
}
