using System;
using System.Linq;
namespace Equal_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string input2 = Console.ReadLine().ToLower();
            if (input.Equals(input2))
                Console.WriteLine("yes");
            else
                Console.WriteLine("no");
        }
    }
}
