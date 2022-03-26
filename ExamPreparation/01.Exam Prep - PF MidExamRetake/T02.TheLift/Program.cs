using System;
using System.Linq;

namespace T02.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int[] lift = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int currentWagon = 0;
            while (people >= 0 && currentWagon < lift.Length)
            {
                int currentFreespace = 4 - lift[currentWagon];
                if (currentFreespace <= people)
                {
                    lift[currentWagon++] += currentFreespace;
                }
                else
                {
                    lift[currentWagon++] += people;
                }
                people -= currentFreespace;
            }

            if (people < 0)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }
            Console.WriteLine(String.Join(" ", lift));
        }
    }
}
