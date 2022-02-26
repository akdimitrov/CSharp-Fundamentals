using System;

namespace T10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int initialPokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int pokedTargets = 0;
            int pokePower = initialPokePower;
            while (pokePower >= distance)
            {
                pokedTargets++;
                pokePower -= distance;
                if (pokePower == (double)(initialPokePower / 2.0))
                {
                    if (exhaustionFactor != 0)
                    {
                        pokePower /= exhaustionFactor;
                    }
                }
            }

            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargets);
        }
    }
}
