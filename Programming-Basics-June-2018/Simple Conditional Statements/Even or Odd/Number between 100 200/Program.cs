using System;

namespace Number_between_100_200
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            if (input < 100) Console.WriteLine("Less than 100");
            if (input >= 100 && input <= 200) Console.WriteLine("Between 100 and 200");
            if (input > 200) Console.WriteLine("Greater than 200");
        }
    }
}
