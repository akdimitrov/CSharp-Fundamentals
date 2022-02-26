using System;

namespace T15.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int charCount = int.Parse(Console.ReadLine());

            bool hasMatch = false;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == 'p')
                {
                    hasMatch = true;
                    int length = charCount + 1;

                    if (length > text.Length - i - 1)
                    {
                        length = text.Length - i;
                    }

                    string matchedString = text.Substring(i, length);
                    Console.WriteLine(matchedString);
                    i += length - 1;
                }
            }

            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}
