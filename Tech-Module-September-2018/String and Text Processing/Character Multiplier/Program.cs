using System;
using System.Collections.Generic;
using System.Linq;

namespace String_and_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Console.WriteLine(Multiplier(input[0], input[1]));
        }

        static int Multiplier(string str1, string str2)
        {
            int sum = 0;
            int length = 0;
            // get the diff and subtract 1 since we will use this as an index;
            int diff = Math.Abs(str1.Length - str2.Length) - 1;
            string longestString = str1.Length > str2.Length ? str1 : str2;
            int startIndex = (longestString.Length - 1) - diff;
            // add all the remaining char codes to total sum
            for (int i = startIndex; i < longestString.Length ; i++)
            {
                sum += longestString[i];
            }
            
            length = startIndex;

            // multiply + add to total sum
            for (int i = 0; i < length; i++)
            {
                sum += str1[i] * str2[i];
            }

            return sum;
        }
    }
}
