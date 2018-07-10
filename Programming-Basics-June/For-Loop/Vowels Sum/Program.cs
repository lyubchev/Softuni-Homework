using System;
using System.Collections.Generic;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                { 'a', 1 },
                { 'e', 2 },
                { 'i', 3 },
                { 'o', 4 },
                { 'u', 5 },
            };
            int sum = 0;
            string input = Console.ReadLine();
            foreach (char letter in input)
            {
                if (map.ContainsKey(letter)) sum += map[letter];
            }
            Console.WriteLine(sum);
        }
    }
}
