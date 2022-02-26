using System;

namespace T01.Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            if (age <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (age <= 65)
            {
                Console.WriteLine("adult");
            }
            else
            {
                Console.WriteLine("elder");
            }
        }
    }
}
