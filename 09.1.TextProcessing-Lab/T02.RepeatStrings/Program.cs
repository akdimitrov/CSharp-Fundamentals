using System;
using System.Text;

namespace T02.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split();
            StringBuilder result = new StringBuilder();
            foreach (string word in array)
            {
                for (int j = 0; j < word.Length; j++)
                {
                    result.Append(word);
                }
            }
            Console.WriteLine(result);
        }
    }
}
