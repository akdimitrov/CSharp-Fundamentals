using System;

namespace T05.TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempF = double.Parse(Console.ReadLine());
            double tempC = FarenheitToCelsius(tempF);
            Console.WriteLine($"{tempC:f2}");
        }

        private static double FarenheitToCelsius(double tempF)
        {
            double result = (tempF - 32) * 5 / 9;
            return result;
        }
    }
}
