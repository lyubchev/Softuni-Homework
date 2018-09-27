using System;

namespace Division {
    class Program {
        static void Main (string[] args) {
            int number = int.Parse (Console.ReadLine ());

            Console.WriteLine(FindDivisible(number) == "0" ? "Not divisible" : $"The number is divisible by {FindDivisible(number)}");
        }

        static string FindDivisible (int number) {

            if (number % 10 == 0) {
                return "10";
            }

            if (number % 7 == 0) {
                return "7";
            }

            if (number % 6 == 0) {
                return "6";
            }

            if (number % 3 == 0) {
                return "3";
            }

            if (number % 2 == 0) {
                return "2";
            } else {
                return "0";
            }
        }
    }
}