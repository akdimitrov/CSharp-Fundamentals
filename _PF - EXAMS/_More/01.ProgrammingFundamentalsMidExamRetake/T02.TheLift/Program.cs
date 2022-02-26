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
            while (people > 0)
            {
                bool isSpaceFound = false;
                for (int i = 0; i < lift.Length; i++)
                {
                    if (lift[i] < 4)
                    {
                        lift[i] += 1;
                        people--;
                        isSpaceFound = true;
                        break;
                    }
                }

                if (!isSpaceFound)
                {
                    break;
                }
            }

            if (people == 0 && lift[lift.Length - 1] < 4)
            {
                Console.WriteLine("The lift has empty spots!");
            }
            else if (people > 0)
            {
                Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            }
            Console.WriteLine(string.Join(" ", lift));
        }
    }
}
