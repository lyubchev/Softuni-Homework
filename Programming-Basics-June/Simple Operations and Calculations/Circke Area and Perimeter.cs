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
            var radius = double.Parse(Console.ReadLine());
            var area = Math.PI * radius * radius;
            var perimeter = 2*Math.PI * radius;
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
