using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(?<=([=\/]))[A-Z][A-Za-z]{2,}(?=\1)");
            MatchCollection places = regex.Matches(Console.ReadLine());
            int travelPoint = places.Sum(x => x.Value.Length);

            Console.WriteLine($"Destinations: {string.Join(", ", places)}");
            Console.WriteLine($"Travel Points: {travelPoint}");
        }
    }
}
