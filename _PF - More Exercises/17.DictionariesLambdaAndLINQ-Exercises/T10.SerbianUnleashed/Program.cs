using System;
using System.Collections.Generic;
using System.Linq;

namespace T10.SerbianUnleashed
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> venueSingers = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] array = input.Split(" @");
                if (array.Length == 2)
                {
                    string singer = array[0];
                    string[] info = array[1].Split();
                    int length = info.Length;
                    if (length > 2 && length < 6)
                    {
                        int price; bool isPriceValid = int.TryParse(info[info.Length - 2], out price);
                        int tickets; bool isTicketsValid = int.TryParse(info[info.Length - 1], out tickets);
                        if (isPriceValid && isTicketsValid)
                        {
                            string venue = string.Empty;
                            for (int i = 0; i < length - 2; i++)
                            {
                                if (i == 0)
                                {
                                    venue = info[i];
                                }
                                else
                                {
                                    venue += $" {info[i]}";
                                }
                            }

                            if (!venueSingers.ContainsKey(venue))
                            {
                                venueSingers[venue] = new Dictionary<string, int>();
                            }
                            if (!venueSingers[venue].ContainsKey(singer))
                            {
                                venueSingers[venue][singer] = 0;
                            }

                            venueSingers[venue][singer] += price * tickets;
                        }
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var venue in venueSingers)
            {
                Console.WriteLine(venue.Key);
                Console.WriteLine(String.Join("\n", venue.Value.OrderByDescending(x => x.Value).Select(x => $"#  {x.Key} -> {x.Value}")));
            }
        }
    }
}
