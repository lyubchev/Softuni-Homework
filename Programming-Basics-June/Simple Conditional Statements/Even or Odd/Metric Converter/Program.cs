using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputUnit = Console.ReadLine();
            string outputUnit = Console.ReadLine();
            switch (inputUnit)
            {
                case "m":
                    break;
                case "mm":
                    number /= 1000;
                    break;
                case "cm":
                    number /= 100;
                    break;
                case "mi":
                    number /= 0.000621371192;
                    break;
                case "in":
                    number /= 39.3700787;
                    break;
                case "km":
                    number /= 0.001;
                    break;
                case "ft":
                    number /= 3.2808399;
                    break;
                case "yd":
                    number /= 1.0936133;
                    break;
            }

            switch (outputUnit)
            {
                case "m":
                    break;
                case "mm":
                    number *= 1000;
                    break;
                case "cm":
                    number *= 100;
                    break;
                case "mi":
                    number *= 0.000621371192;
                    break;
                case "in":
                    number *= 39.3700787;
                    break;
                case "km":
                    number *= 0.001;
                    break;
                case "ft":
                    number *= 3.2808399;
                    break;
                case "yd":
                    number *= 1.0936133;
                    break;
            }
            Console.WriteLine(number + " " + outputUnit);
        }
    }
}
