using System;
using System.Collections.Generic;
using System.Linq;

namespace T05.ShortWordsSorted
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = { '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?', ' ' };
            List<string> words = Console.ReadLine().ToLower().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            words = words.Distinct().Where(x => x.Length < 5).OrderBy(x => x).ToList();
            Console.WriteLine(String.Join(", ", words));
        }
    }
}
