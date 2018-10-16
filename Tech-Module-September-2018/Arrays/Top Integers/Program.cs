using System;
using System.Linq;

namespace Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool isTopNum = true;
            string topNums = "";
            for (int i = 0; i < nums.Length; i++)
            {
                // 27 19 42 2 13 45 48

                // 
                //
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] <= nums[j])
                    {
                        break;
                    }
                    else if (j == nums.Length - 1)
                    {
                        topNums += nums[i] + " ";
                    }
                }
            }

            topNums += nums.Last() + " ";

            Console.WriteLine(topNums);
        }
    }
}
