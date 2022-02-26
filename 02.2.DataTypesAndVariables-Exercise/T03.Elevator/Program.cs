using System;

namespace T03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());
            double courese = Math.Ceiling(people / capacity);
            Console.WriteLine(courese);
        }
    }
}
