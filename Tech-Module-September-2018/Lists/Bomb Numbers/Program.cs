using System;
using System.Collections.Generic;
using System.Linq;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string bombSpecs = Console.ReadLine();
            int bombTarget = int.Parse(bombSpecs.Split()[0]);
            int bombPower = int.Parse(bombSpecs.Split()[1]);

            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] == bombTarget)
                {
                    int start = Math.Max(0, i - bombPower);
                    int end = Math.Min((2 * bombPower) + 1, numbers.Count() - start);
                    numbers.RemoveRange(start, end);
                    i = -1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
