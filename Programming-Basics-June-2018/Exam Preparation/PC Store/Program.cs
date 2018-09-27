using System;

namespace PC_STORE
{
    class Program
    {
        static void Main(string[] args)
        {
            const double dollar = 1.57;
            double processor = double.Parse(Console.ReadLine());
            double videoCard = double.Parse(Console.ReadLine());
            double ram = double.Parse(Console.ReadLine());
            int ramAmount = int.Parse(Console.ReadLine());
            double discount = 1 - double.Parse(Console.ReadLine());
            double total = (discount * videoCard) + (discount * processor) + (ram * ramAmount);
            total *= dollar;
            System.Console.WriteLine($"Money needed - {total:F2} leva.");
        }
    }
}
