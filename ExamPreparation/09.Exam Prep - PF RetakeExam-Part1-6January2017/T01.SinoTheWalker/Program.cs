using System;
using System.Numerics;

namespace T01.SinoTheWalker
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] time = Console.ReadLine().Split(':');
            BigInteger hours = BigInteger.Parse(time[0]);
            BigInteger minutes = BigInteger.Parse(time[1]);
            BigInteger seconds = BigInteger.Parse(time[2]);
            int steps = int.Parse(Console.ReadLine());
            BigInteger stepSeconds = BigInteger.Parse(Console.ReadLine());

            BigInteger walkingTime = steps * stepSeconds;
            seconds += walkingTime;
            minutes += seconds / 60;
            seconds %= 60;
            hours += minutes / 60;
            minutes %= 60;
            hours %= 24;

            Console.WriteLine($"Time Arrival: {hours:d2}:{minutes:d2}:{seconds:d2}");
        }
    }
}
