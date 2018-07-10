using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double OddSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenSum = 0;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;
            double input = 0;
            List<double> Evens = new List<double>();
            List<double> Odds = new List<double>();
            for (int i = 1; i <= n ; i++)
            {
                input = double.Parse(Console.ReadLine());
                if (i % 2 == 0) Evens.Add(input);
                else Odds.Add(input);
            }
            Odds.Sort();
            Evens.Sort();
            try
            {
                OddSum = Odds.Sum();
                OddMin = Odds[0];
                OddMax = Odds.Last();
                EvenMin = Evens[0];
                EvenMax = Evens.Last();
                EvenSum = Evens.Sum();
            }
            catch (Exception)
            { }
            Console.WriteLine("OddSum={0}", OddSum);
            string result = Odds.Count == 0 ? "No" : OddMin.ToString();
            Console.WriteLine("OddMin={0}", result);
            result = Odds.Count == 0 ? "No" : OddMax.ToString();
            Console.WriteLine("OddMax={0}", result);
            Console.WriteLine("EvenSum={0}", EvenSum);
            result = Evens.Count == 0 ? "No" : EvenMin.ToString();
            Console.WriteLine("EvenMin={0}", result);
            result = Evens.Count == 0 ? "No" : EvenMax.ToString();
            Console.WriteLine("EvenMax={0}", result);

        }
    }
}
