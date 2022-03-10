using System;
using System.Diagnostics;

namespace T03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();
            while (text.Contains(word))
            {
                text = text.Replace(word, "");
            }
            Console.WriteLine(text);
        }
    }
}
