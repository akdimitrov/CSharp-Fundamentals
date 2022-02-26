using System;
using System.Collections.Generic;
using System.Linq;

namespace T01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            int num = 0;
            int startIndex = 0;
            int max = 0;
            for (int i = 0; i < list.Count - 1; i++)
            {
                int counter = 1;
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (counter > max)
                {
                    max = counter;
                    num = list[i];
                    startIndex = i;
                }
            }

            for (int i = startIndex; i < startIndex + max; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
