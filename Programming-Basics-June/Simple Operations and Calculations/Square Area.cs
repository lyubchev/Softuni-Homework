using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double angle = double.Parse(Console.ReadLine());
            double deg;
            deg = angle * (180.0 / Math.PI);
            Console.WriteLine(Math.Round(deg));
        }
    }
}
