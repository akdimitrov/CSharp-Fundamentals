using System;
using System.Collections.Generic;
using System.Linq;

namespace T09.PokemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sum = 0;
            while (list.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int pokemon = 0;
                if (index < 0)
                {
                    pokemon = list[0];
                    list[0] = list[^1];

                }
                else if (index >= list.Count)
                {
                    pokemon = list[^1];
                    list[^1] = list[0];
                }
                else
                {
                    pokemon = list[index];
                    list.RemoveAt(index);
                }

                list = list.Select(x => x <= pokemon ? x += pokemon : x -= pokemon).ToList();
                sum += pokemon;
            }
            Console.WriteLine(sum);
        }
    }
}
