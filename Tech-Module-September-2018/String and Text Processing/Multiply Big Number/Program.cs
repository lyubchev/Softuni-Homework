using System;
using System.Linq;
using System.Text;

namespace Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());

            string product = number == "0" || multiplier == 0 ? "0" : Multiply(number, multiplier);
            Console.WriteLine(product);
        }

        static string Multiply(string number, int multiplier)
        {
            string product = "";
            int remainder = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int result = int.Parse(number[i].ToString());
                result = (result * multiplier) + remainder;
                int digit = result % 10;
                remainder = result / 10;
                product = digit.ToString() + product;

                if (i == 0 && remainder != 0)
                {
                    product = remainder.ToString() + product;
                }
            }

            return product;
        }
    }
}
