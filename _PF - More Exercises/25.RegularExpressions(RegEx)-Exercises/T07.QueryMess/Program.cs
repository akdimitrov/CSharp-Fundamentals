using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T07.QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<=[&?]|^)(?<field>[^?]+?)=(?<value>[^?]+?)(?=[&?]|$)");
            Regex replaceSpaces = new Regex(@"((%20|\+)+)");
            string input = Console.ReadLine();
            while (input != "END")
            {
                Dictionary<string, List<string>> fieldValuePairs = new Dictionary<string, List<string>>();
                MatchCollection matches = regex.Matches(replaceSpaces.Replace(input, " "));
                foreach (Match match in matches)
                {
                    string field = match.Groups["field"].Value.Trim();
                    string value = match.Groups["value"].Value.Trim();
                    if (!fieldValuePairs.ContainsKey(field))
                    {
                        fieldValuePairs[field] = new List<string>();
                    }
                    fieldValuePairs[field].Add(value);
                }
                Console.WriteLine(String.Join("", fieldValuePairs.Select(x => $"{x.Key}=[{string.Join(", ", x.Value)}]")));
                input = Console.ReadLine();
            }
        }
    }
}
