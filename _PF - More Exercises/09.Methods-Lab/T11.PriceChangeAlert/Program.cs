using System;

namespace T11.PriceChangeAlert
{
    class Program
    {
        static void Main(string[] args)
        {
            int prices = int.Parse(Console.ReadLine());
            double threshold = double.Parse(Console.ReadLine());
            double lastPrice = double.Parse(Console.ReadLine());

            for (int i = 0; i < prices - 1; i++)
            {
                double currentPrice = double.Parse(Console.ReadLine());
                double difference = GetDifference(lastPrice, currentPrice);
                bool isSignificant = isSignificantDifference(threshold, difference);
                string message = GetDifferenceType(currentPrice, lastPrice, difference, isSignificant);
                Console.WriteLine(message);

                lastPrice = currentPrice;
            }
        }

        private static string GetDifferenceType(double currentPrice, double lastPrice, double difference, bool isSignificant)
        {
            string message = "";
            if (difference == 0)
            {
                message = string.Format("NO CHANGE: {0}", currentPrice);
            }
            else if (!isSignificant)
            {
                message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (isSignificant && (difference > 0))
            {
                message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }
            else if (isSignificant && (difference < 0))
            {
                message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
            }

            return message;
        }

        static bool isSignificantDifference(double threshold, double difference)
        {
            if (Math.Abs(difference) >= threshold)
            {
                return true;
            }
            return false;
        }

        private static double GetDifference(double lastPrice, double currentPrice)
        {
            double difference = (currentPrice - lastPrice) / lastPrice;
            return difference;
        }
    }
}
