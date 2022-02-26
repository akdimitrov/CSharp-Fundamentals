using System;

namespace T01.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int day = int.Parse(Console.ReadLine());
            if (day > 0  && day <= 7)
            {
                Console.WriteLine(weekDays[day - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
