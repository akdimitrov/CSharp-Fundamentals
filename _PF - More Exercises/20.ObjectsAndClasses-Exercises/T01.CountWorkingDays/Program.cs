using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace T01.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime date2 = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(GetWorkingDays(date1, date2));
        }

        static int GetWorkingDays(DateTime date1, DateTime date2)
        {
            int workingDays = 0;
            for (DateTime date = date1; date <= date2; date = date.AddDays(1))
            {
                DateTime[] holidays =
                    {
                    new DateTime(date.Year, 1, 1),
                    new DateTime(date.Year, 3, 3),
                    new DateTime(date.Year, 5, 1),
                    new DateTime(date.Year, 5, 6),
                    new DateTime(date.Year, 5, 24),
                    new DateTime(date.Year, 9, 6),
                    new DateTime(date.Year, 9, 22),
                    new DateTime(date.Year, 11, 1),
                    new DateTime(date.Year, 12, 24),
                    new DateTime(date.Year, 12, 25),
                    new DateTime(date.Year, 12, 26),
                };

                if (!holidays.Contains(date) && date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
                {
                    workingDays++;
                }
            }

            return workingDays;
        }
    }
}
