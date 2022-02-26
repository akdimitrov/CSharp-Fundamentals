using System;
using System.Collections.Generic;
using System.Linq;

namespace T08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> logs = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string ip = input[0];
                string name = input[1];
                int duration = int.Parse(input[2]);
                if (!logs.ContainsKey(name))
                {
                    logs[name] = new Dictionary<string, int>();
                }
                if (!logs[name].ContainsKey(ip))
                {
                    logs[name][ip] = 0;
                }
                logs[name][ip] += duration;
            }

            foreach (var user in logs.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}: {user.Value.Sum(x => x.Value)} [{String.Join(", ", user.Value.Keys.OrderBy(x => x))}]");
            }
        }
    }
}
