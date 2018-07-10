using System;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0, odd = 0;
            int diff = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    even += int.Parse(Console.ReadLine());
                else
                    odd += int.Parse(Console.ReadLine());
            }
            diff = Math.Abs(even - odd);
            if (even == odd)
                Console.WriteLine("Yes, sum = {0}", even);
            else
                Console.WriteLine("No, diff = {0}", diff);
        }
    }
}
