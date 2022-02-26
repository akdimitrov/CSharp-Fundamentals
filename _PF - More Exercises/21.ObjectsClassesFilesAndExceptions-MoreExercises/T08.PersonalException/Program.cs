using System;

namespace T08.PersonalException
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    uint input = uint.Parse(Console.ReadLine());
                    Console.WriteLine(input);
                }
                catch
                {
                    Console.WriteLine("My first exception is awesome!!!");
                    break;
                }
            }
        }
    }
}
