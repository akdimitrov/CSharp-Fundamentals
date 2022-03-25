using System;
using System.Text;

namespace T01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stops = new StringBuilder(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "Travel")
            {
                string[] tokens = command.Split(':');
                string action = tokens[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(tokens[1]);
                    if (index >= 0 && index < stops.Length)
                    {
                        stops.Insert(index, tokens[2]);
                    }
                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    if (startIndex >= 0 && startIndex < stops.Length &&
                        endIndex >= 0 && endIndex < stops.Length)
                    {
                        stops.Remove(startIndex, endIndex - startIndex + 1);
                    }
                }
                else if (action == "Switch")
                {
                    stops.Replace(tokens[1], tokens[2]);
                }

                Console.WriteLine(stops);
                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
