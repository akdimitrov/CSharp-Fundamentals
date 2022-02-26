using System;

namespace T09.IndexOfLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array = new char[26];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (char)('a' + i);
            }

            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (input[i] == array[j])
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                        break;
                    }
                }
            }
        }
    }
}
