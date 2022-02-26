using System;

namespace T09.CharsToString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = string.Empty;
            for (int i = 0; i < 3; i++)
            {
                word += char.Parse(Console.ReadLine());
            }
            Console.WriteLine(word);
        }
    }
}
