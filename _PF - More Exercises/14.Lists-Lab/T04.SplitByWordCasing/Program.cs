using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };

            List<string> list = Console.ReadLine().Split(separators).ToList();
            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            for (int i = 0; i < list.Count; i++)
            {
                string word = list[i];
                bool isLowerCase = false;
                bool isUpperCase = false;
                bool isMixedCase = false;

                for (int j = 0; j < word.Length; j++)
                {
                    if (word[j] >= 'a' && word[j] <= 'z')
                    {
                        isLowerCase = true;
                    }
                    else if (word[j] >= 'A' && word[j] <= 'Z')
                    {
                        isUpperCase = true;
                    }
                    else
                    {
                        isMixedCase = true;
                        break;
                    }

                    if (isLowerCase && isUpperCase)
                    {
                        isMixedCase = true;
                        break;
                    }
                }

                if (isMixedCase)
                {
                    mixedCaseWords.Add(word);
                }
                else if (isLowerCase)
                {
                    lowerCaseWords.Add(word);
                }
                else if (isUpperCase)
                {
                    upperCaseWords.Add(word);
                }
            }

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }
    }
}
