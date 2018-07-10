using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0, right = 0;
            int diff = 0;
            for (int i = 0; i < n * 2; i++)
            {
                if (i < n)
                {
                    left += int.Parse(Console.ReadLine());
                }
                else
                {
                    right += int.Parse(Console.ReadLine());
                }
            }
            diff = Math.Abs(left - right);
            if (diff == 0) Console.WriteLine("Yes, sum = {0}",left);
            else Console.WriteLine("No, diff = {0}", diff);
        }
    }
}
