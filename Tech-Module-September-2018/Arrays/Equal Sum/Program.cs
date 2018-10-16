using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int leftSum = arr.Sum();
            int rightSum = 0;
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                rightSum += arr[i];

                if (rightSum == leftSum)
                {
                    index = i;
                }

                leftSum -= arr[i];

            }
            Console.WriteLine(index > -1 ? index.ToString() : "no");
        }
    }
}