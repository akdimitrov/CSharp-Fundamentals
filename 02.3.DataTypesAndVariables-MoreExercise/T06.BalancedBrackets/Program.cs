using System;

namespace T06.BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isbalanced = true;
            string lastBracket = string.Empty;
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (input == lastBracket)
                {
                    isbalanced = false;
                }

                if (input == "(")
                {
                    lastBracket = input;
                }
                else if (input == ")")
                {
                    if (lastBracket == String.Empty)
                    {
                        isbalanced = false;
                    }
                    lastBracket = input;
                }
            }
            if (lastBracket == "(")
            {
                isbalanced = false;
            }
            Console.WriteLine(isbalanced ? "BALANCED" : "UNBALANCED");
        }
    }
}
