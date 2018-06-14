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
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            double a = Math.Abs(x2 - x1);
            double b = Math.Abs(y2 - y1);
            Console.WriteLine(a*b);
            Console.WriteLine(2*(a + b));
        }
    }
}
