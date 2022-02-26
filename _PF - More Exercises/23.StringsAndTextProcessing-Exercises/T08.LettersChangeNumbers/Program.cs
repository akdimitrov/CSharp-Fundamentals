using System;

namespace T08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            decimal result = 0;
            foreach (var item in input)
            {
                char first = item[0];
                char last = item[item.Length - 1];
                decimal number = decimal.Parse(item.Substring(1, item.Length - 2));
                number = char.IsUpper(first) ? number / (first - 64) : number * (first - 96);
                number = char.IsUpper(last) ? number - last + 64 : number + last - 96;
                result += number;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
