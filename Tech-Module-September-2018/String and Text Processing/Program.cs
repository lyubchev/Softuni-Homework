using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace String_and_Text_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine()
            .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

            
            string pattern = @"^\b[A-Za-z0-9_-]{3,16}$";
            Regex reg = new Regex(pattern);
            var validInputs = new List<string>();

            foreach (var input in inputs)
            {
                var match = reg.Match(input);

                if (match.Value != "")
                {
                    validInputs.Add(match.Value);
                }
            }

            Console.WriteLine(string.Join("\n", validInputs));
        }
    }
}
