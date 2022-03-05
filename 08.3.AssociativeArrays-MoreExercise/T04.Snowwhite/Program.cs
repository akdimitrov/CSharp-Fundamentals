using System;
using System.Collections.Generic;
using System.Linq;

namespace T04.Snowwhite
{
    class Dwarf
    {
        public Dwarf(string name, string color, int physics)
        {
            this.Name = name;
            this.Color = color;
            this.Physics = physics;
        }

        public string Name { get; set; }

        public string Color { get; set; }

        public int Physics { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarfs = new List<Dwarf>();
            string input = Console.ReadLine();
            while (input != "Once upon a time")
            {
                string[] info = input.Split(" <:> ");
                string name = info[0];
                string color = info[1];
                int physics = int.Parse(info[2]);
                Dwarf dwarf = dwarfs.FirstOrDefault(x => x.Name == name && x.Color == color);

                if (dwarf == null)
                {
                    dwarfs.Add(new Dwarf(name, color, physics));
                }
                else if (dwarf.Physics < physics)
                {
                    dwarfs.Remove(dwarf);
                    dwarfs.Add(new Dwarf(name, color, physics));
                }

                input = Console.ReadLine();
            }

            foreach (var dwarf in dwarfs.OrderByDescending(x => x.Physics).ThenByDescending(x => dwarfs.Count(y => y.Color == x.Color)))
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}
