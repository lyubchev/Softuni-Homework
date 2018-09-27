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
            var inches = double.Parse(Console.ReadLine());
            var cm = inches * 2.54;
            Console.WriteLine(cm);
        }
    }
}
