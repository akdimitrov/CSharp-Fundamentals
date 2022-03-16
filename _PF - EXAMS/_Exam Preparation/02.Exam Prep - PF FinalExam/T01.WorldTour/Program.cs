using System;

namespace T01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Travel")
            {
                string[] cmd = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string action = cmd[0];
                if (action == "Add Stop")
                {
                    int index = int.Parse(cmd[1]);
                    string stop = cmd[2];
                    if (IsIndexValid(index, stops))
                    {
                        stops = stops.Insert(index, stop);
                    }
                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    if (IsIndexValid(startIndex, stops) && IsIndexValid(endIndex, stops) && startIndex <= endIndex)
                    {
                        stops = stops.Remove(startIndex, endIndex - startIndex + 1);
                    }
                }
                else if (action == "Switch")
                {
                    stops = stops.Replace(cmd[1], cmd[2]);
                }

                Console.WriteLine(stops);
                command = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }

        static bool IsIndexValid(int index, string text)
        {
            return index >= 0 && index < text.Length;
        }
    }
}
