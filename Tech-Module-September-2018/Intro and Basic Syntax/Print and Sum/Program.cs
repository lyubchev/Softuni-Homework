using System;

namespace Print_and_Sum {
    class Program {
        static void Main (string[] args) {
            int start = int.Parse (Console.ReadLine ());
            int end = int.Parse (Console.ReadLine ());
            int sum = 0;

            for (int i = start; i <= end; i++) {
                sum += i;
                if (i >= start && i < end) {
                    Console.Write (i + " ");
                } else if (i == end) {
                    Console.Write (i);
                }
            }
            Console.WriteLine ($"\nSum: {sum}");
        }
    }
}