using System;

namespace Ex
{
    class Number_in_Range
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());
            while (range < 1 || range > 100)
            {
                Console.WriteLine("Invalid number!");
                range = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The number is: " + range);
        }
    }
}
