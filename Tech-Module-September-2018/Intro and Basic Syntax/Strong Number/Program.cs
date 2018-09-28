using System;

namespace Strong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            if(IsStrongNumber(number)) {
                Console.WriteLine("yes");
            } else {
                Console.WriteLine("no");
            }
        }

        static bool IsStrongNumber(string number) {

            int total = 0;

            for (int i = 0; i < number.Length; i++) {
                total += factorial(int.Parse(number[i].ToString()));
            }
            return (total == int.Parse(number)) ? true: false;
        }

        static int factorial(int n) => (n <= 1) ? 1 : n * factorial(n-1);
    }
}
