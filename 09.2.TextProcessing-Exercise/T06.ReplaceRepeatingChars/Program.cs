using System;
using System.Text;

namespace T06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new StringBuilder(text[0].ToString());
            foreach (var ch in text)
            {
                if (result[^1] != ch)
                {
                    result.Append(ch);
                }
            }
            Console.WriteLine(result);
        }
    }
}
