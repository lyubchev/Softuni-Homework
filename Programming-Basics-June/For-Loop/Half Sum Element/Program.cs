using System;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int n = int.Parse(Console.ReadLine());
            int input = 0;
            int sum =0;
            for (int i = 0; i < n; i++)
            {
                input = int.Parse(Console.ReadLine());
                if (input >= max) max = input;
                sum += input;
            }
            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = "+(sum-max));
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = "+(Math.Abs(max-(sum-max))));
            }
        }
    }
}
