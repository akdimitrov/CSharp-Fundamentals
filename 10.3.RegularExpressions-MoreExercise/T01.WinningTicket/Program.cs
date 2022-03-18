using System;
using System.Text.RegularExpressions;

namespace T01.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"@{6,}|#{6,}|\${6,}|\^{6,}");
            string[] tickets = Console.ReadLine()
                    .Split(new char[] { ',', ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                Match left = regex.Match(ticket.Substring(0, 10));
                Match right = regex.Match(ticket.Substring(10));
                if (left.Success && right.Success && left.Value[0] == right.Value[0])
                {
                    int count = Math.Min(left.Value.Length, right.Value.Length);
                    Console.WriteLine(count == 10 ?
                        $"ticket \"{ticket}\" - 10{left.Value[0]} Jackpot!" :
                        $"ticket \"{ticket}\" - {count}{left.Value[0]}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }
    }
}
