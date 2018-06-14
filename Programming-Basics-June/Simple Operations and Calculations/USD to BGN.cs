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
           const double k = 1.79549;
           double usd = double.Parse(Console.ReadLine());
           Console.WriteLine(usd*k);
        }
    }
}
