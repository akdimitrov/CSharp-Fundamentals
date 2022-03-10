using System;
using System.Numerics;

namespace T08.LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequences = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;
            foreach (var seq in sequences)
            {
                decimal number = decimal.Parse(seq.Substring(1, seq.Length - 2));
                char first = seq[0];
                char last = seq[^1];
                number = char.IsUpper(first) ? number / (first - 'A' + 1) : number * (first - 'a' + 1);
                number = char.IsUpper(last) ? number - (last - 'A' + 1) : number + (last - 'a' + 1);
                sum += number;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
