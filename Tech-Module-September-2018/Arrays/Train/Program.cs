using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
               arr[i] = int.Parse(Console.ReadLine());
            }

            int arrSum = arr.Sum();
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(arrSum);
        }
    }


using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
               arr[i] = int.Parse(Console.ReadLine());
            }

            int arrSum = arr.Sum();
            Console.WriteLine(string.Join(" ", arr));
            Console.WriteLine(arrSum);
        }
    }
}}