using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.TreasureFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            while (input != "find")
            {
                Queue<int> queue = new Queue<int>(keys);
                char[] array = input.ToCharArray();
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] -= (char)queue.Peek();
                    queue.Enqueue(queue.Dequeue());
                }
                string decrypted = new string(array);

                int treasureIndex = decrypted.IndexOf('&') + 1;
                int treasureLength = decrypted.LastIndexOf('&') - treasureIndex;
                string treasure = decrypted.Substring(treasureIndex, treasureLength);

                int coordinatesIndex = decrypted.IndexOf('<') + 1;
                int coordinatesLength = decrypted.IndexOf('>') - coordinatesIndex;
                string coordinates = decrypted.Substring(coordinatesIndex, coordinatesLength);

                Console.WriteLine($"Found {treasure} at {coordinates}");
                input = Console.ReadLine();
            }
        }
    }
}
