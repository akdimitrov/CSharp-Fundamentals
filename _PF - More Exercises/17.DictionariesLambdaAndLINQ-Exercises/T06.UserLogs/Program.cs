using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.UserLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> usersIp = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string ip = input.Split()[0].Split("=")[1];
                string name = input.Split()[2].Split("=")[1];
                if (!usersIp.ContainsKey(name))
                {
                    usersIp[name] = new Dictionary<string, int>();
                }
                if (!usersIp[name].ContainsKey(ip))
                {
                    usersIp[name][ip] = 0;
                }
                usersIp[name][ip]++;

                input = Console.ReadLine();
            }

            foreach (var user in usersIp.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key}:");
                Console.WriteLine($"{String.Join(", ", user.Value.Select(x => $"{x.Key} => {x.Value}"))}.");
            }
        }
    }
}
