using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T04.Weather
{
    class Weather
    {
        public Weather(string city, double temp, string type)
        {
            City = city;
            AverageTemp = temp;
            WeatherType = type;
        }

        public string City { get; set; }

        public double AverageTemp { get; set; }

        public string WeatherType { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Weather> weatherForecast = new List<Weather>();
            Regex weatherInfoValidation = new Regex(@".*(?<city>[A-Z]{2})(?<temperature>\d{2}\.\d{1,2})(?<weatherType>[A-Za-z]+)\|+");
            string input = Console.ReadLine();
            while (input != "end")
            {
                Match match = weatherInfoValidation.Match(input);
                if (match.Success)
                {
                    string city = match.Groups["city"].Value;
                    double temperature = double.Parse(match.Groups["temperature"].Value);
                    string type = match.Groups["weatherType"].Value;
                    if (weatherForecast.Any(x => x.City == city))
                    {
                        weatherForecast.Remove(weatherForecast.First(x => x.City == city));
                    }
                    weatherForecast.Add(new Weather(city, temperature, type));
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(String.Join("\n", weatherForecast.OrderBy(x => x.AverageTemp).Select(x => $"{x.City} => {x.AverageTemp:f2} => {x.WeatherType}")));
        }
    }
}
