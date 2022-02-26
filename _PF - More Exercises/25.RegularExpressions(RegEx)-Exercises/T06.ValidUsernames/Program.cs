using System;
using System.Text.RegularExpressions;

namespace T06.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex usernamePattern = new Regex(@"(?<=[ \/\\)(]|\b)(?<userame>[A-Za-z]\w{2,24})(?=[ \/\\)(]|\b)");
            MatchCollection matches = usernamePattern.Matches(Console.ReadLine());
            int maxSum = 0;
            string result = string.Empty;
            for (int i = 0; i < matches.Count - 1; i++)
            {
                int currentSum = matches[i].Length + matches[i + 1].Length;
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    result = $"{matches[i].Value}\n{matches[i + 1].Value}";
                }
            }
            Console.WriteLine(result);
        }
    }
}
