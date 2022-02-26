using System;
using System.Linq;

namespace T02.CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] race = Console.ReadLine().Split().Select(int.Parse).ToArray();
            double leftSum = 0;
            double rightSum = 0;
            for (int i = 0; i < race.Length / 2; i++)
            {
                leftSum += race[i];
                if (race[i] == 0)
                {
                    leftSum *= 0.80;
                }
            }

            for (int i = race.Length - 1; i > race.Length / 2; i--)
            {
                rightSum += race[i];
                if (race[i] == 0)
                {
                    rightSum *= 0.80;
                }
            }

            Console.WriteLine(leftSum < rightSum ? $"The winner is left with total time: {Math.Round(leftSum, 1)}" : $"The winner is right with total time: {Math.Round(rightSum, 1)}");
        }
    }
}
