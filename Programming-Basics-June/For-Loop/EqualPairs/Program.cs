using System;

namespace EqualPairs
{
    public class Launcher
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double currentSum = 0;
            double previousSum = 0;
            double maxDifference = 0;

            for (int i = 0; i < n; i++)
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                currentSum = num1 + num2;

                if (i > 0)
                {
                    double difference = Math.Abs(currentSum - previousSum);

                    if (difference > maxDifference)
                    {
                        maxDifference = difference;
                    }
                }

                previousSum = currentSum;
            }

            if (maxDifference == 0)
            {
                Console.WriteLine("Yes, value={0}", currentSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", maxDifference);
            }
        }
    }
}