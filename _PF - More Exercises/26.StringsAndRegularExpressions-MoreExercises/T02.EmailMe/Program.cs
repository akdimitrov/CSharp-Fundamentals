using System;
using System.Linq;

namespace T02.EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] email = Console.ReadLine().Split("@");
            Console.WriteLine(email[0].Sum(x => x) >= email[1].Sum(x => x) ? "Call her!" : "She is not the one.");
        }
    }
}
