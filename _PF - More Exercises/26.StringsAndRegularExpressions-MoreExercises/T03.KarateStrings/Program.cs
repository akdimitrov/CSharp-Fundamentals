using System;
using System.Text;

namespace T03.KarateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            int counter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    result.Append(input[i]);
                    counter += int.Parse(input[i + 1].ToString());
                }
                else if (counter == 0)
                {
                    result.Append(input[i]);
                }
                else
                {
                    counter--;
                }
            }
            Console.WriteLine(result);
        }
    }
}
