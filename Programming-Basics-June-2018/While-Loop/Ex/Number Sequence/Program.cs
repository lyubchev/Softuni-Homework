using System;

namespace Number_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int min = int.MaxValue;
            int max = int.MinValue;
            input = Console.ReadLine();

            while (input != "END")
            {

                if (int.Parse(input) >= max)
                {
                    max = int.Parse(input);
                }
                if (int.Parse(input) <= min)
                {
                    min = int.Parse(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine("Max number: "+ max);
            Console.WriteLine("Min number: " + min);
        }
    }
}
