using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int current = 0;
            int currentLength = 1;
            int best = 0;
            int bestLength = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                current = arr[i];
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (current == arr[j])
                    {
                        currentLength++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (currentLength > bestLength)
                {
                    best = current;
                    bestLength = currentLength;
                }
                currentLength = 1;
            }

            if (bestLength == 1)
            {
                best = arr[0];
            }

            for (int i = 0; i < bestLength; i++)
            {
                Console.Write(best + " ");
            }
        }
    }
}
