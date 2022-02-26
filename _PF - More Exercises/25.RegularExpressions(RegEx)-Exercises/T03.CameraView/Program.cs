using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Regex regex = new Regex($@"\|<\w{{{array[0]}}}(\w{{0,{array[1]}}})");
            MatchCollection matches = regex.Matches(Console.ReadLine());
            Console.WriteLine(String.Join(", ", matches.Select(x => x.Groups[1])));
        }
    }
}
