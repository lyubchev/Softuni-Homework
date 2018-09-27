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
            var C = double.Parse(Console.ReadLine());

            var F = C * 1.8 + 32;

            Console.WriteLine(Math.Round(F, 2));
        }
    }
}
