using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.TakeSkipRope
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<int> digits = text.ToCharArray().Where(x => Char.IsDigit(x)).Select(x => int.Parse(x.ToString())).ToList();
            text = string.Join("", text.ToCharArray().Where(x => !char.IsDigit(x)));
            int index = 0;
            for (int i = 0; i < digits.Count - 1; i += 2)
            {
                index += digits[i];
                if (index >= text.Length - 1) break;
                text = text.Remove(index, digits[i + 1]);
            }

            Console.WriteLine(index < text.Length ? text = text.Remove(index) : text);
        }
    }
}
