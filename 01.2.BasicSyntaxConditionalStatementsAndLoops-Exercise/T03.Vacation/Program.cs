using System;

namespace T03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;

            if (groupType == "Students")
            {
                if (day == "Friday")
                {
                    price = 8.45;
                }
                else if (day == "Saturday")
                {
                    price = 9.80;
                }
                else if (day == "Sunday")
                {
                    price = 10.46;
                }

                price *= people;
                if (people >= 30)
                {
                    price *= 0.85;
                }
            }
            else if (groupType == "Business")
            {
                if (day == "Friday")
                {
                    price = 10.90;
                }
                else if (day == "Saturday")
                {
                    price = 15.60;
                }
                else if (day == "Sunday")
                {
                    price = 16;
                }

                if (people >= 100)
                {
                    people -= 10;
                    price *= people;
                }
                else
                {
                    price *= people;
                }
            }
            else if (groupType == "Regular")
            {
                if (day == "Friday")
                {
                    price = 15;
                }
                else if (day == "Saturday")
                {
                    price = 20;
                }
                else if (day == "Sunday")
                {
                    price = 22.50;
                }

                price *= people;
                if (people >= 10 && people <= 20)
                {
                    price *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
