using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',', '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            foreach (var word in input)
            {
                bool isPalindrome = true;
                for (int i = 0; i < word.Length / 2; i++)
                {
                    if (word[i] != word[word.Length - 1 - i])
                    {
                        isPalindrome = false;
                    }
                }

                if (isPalindrome)
                {
                    palindromes.Add(word);
                }
            }

            palindromes = palindromes.Distinct().ToList();
            Console.WriteLine(string.Join(", ", palindromes.OrderBy(x => x)));
        }
    }
}
