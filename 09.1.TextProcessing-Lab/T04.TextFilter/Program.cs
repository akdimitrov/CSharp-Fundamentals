using System;

namespace T04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedList = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();
            foreach (var word in bannedList)
            {
                text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);
        }
    }
}
