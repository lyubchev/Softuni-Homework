using System;

namespace _3_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double input1 = double.Parse(Console.ReadLine());
            double input2 = double.Parse(Console.ReadLine());
            double input3 = double.Parse(Console.ReadLine());

            if (input1==input2&&input2==input3)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
