using System;
using System.Numerics;

namespace T11.Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger maxValue = 0;
            string bestSnowball = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int snow = int.Parse(Console.ReadLine());
                int time = int.Parse(Console.ReadLine());
                int quality = int.Parse(Console.ReadLine());
                BigInteger value = BigInteger.Pow(snow / time, quality);
                if (value > maxValue)
                {
                    maxValue = value;
                    bestSnowball = $"{snow} : {time} = {value} ({quality})";
                }
            }

            Console.WriteLine(bestSnowball);
        }
    }
}
