using System;
using System.Collections.Generic;
using System.Linq;

namespace T06.FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int length = numbers.Count / 4;
            List<int> list1 = numbers.Take(length).Reverse().ToList();
            List<int> list2 = numbers.Skip(length * 3).Take(length).Reverse().ToList();
            List<int> baseList = numbers.Skip(length).Take(length * 2).ToList(); ;
            list1.AddRange(list2);
            var sum = list1.Select((x, index) => x + baseList[index]).ToList();
            Console.WriteLine(String.Join(" ", sum));
        }
    }
}
