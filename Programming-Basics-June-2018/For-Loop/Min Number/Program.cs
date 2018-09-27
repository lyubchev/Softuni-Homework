using System;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int value = 0;
            for (int i = 0; i < n; i++)
            {
                value = int.Parse(Console.ReadLine());
                if (value <= min)
                {
                    min = value;
                }
            }
            Console.WriteLine(min);
        }
    }
}
