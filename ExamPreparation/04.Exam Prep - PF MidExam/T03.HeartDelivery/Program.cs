using System;
using System.Linq;

namespace T03.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split("@").Select(int.Parse).ToArray();
            string[] command = Console.ReadLine().Split();
            int currentIndex = 0;
            while (command[0] != "Love!")
            {
                int jump = int.Parse(command[1]);
                currentIndex += jump;
                if (currentIndex >= array.Length)
                {
                    currentIndex = 0;
                }

                if (array[currentIndex] == 0)
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }
                else
                {
                    array[currentIndex] -= 2;
                    if (array[currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                }

                command = Console.ReadLine().Split();
            }

            bool isAllVisitted = true;
            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 0)
                {
                    isAllVisitted = false;
                    counter++;
                }
            }

            Console.WriteLine($"Cupid's last position was {currentIndex}.");
            if (isAllVisitted)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }
    }
}
