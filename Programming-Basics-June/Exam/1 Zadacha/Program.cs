using System;

namespace _1_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int sectors = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());
            
            double incomePerSector = (capacity * ticketPrice) / sectors;
            double totalIncome = incomePerSector * sectors;
            double charity = (totalIncome - (incomePerSector * 0.75)) / 8;
            Console.WriteLine($"Total income - {totalIncome:F2} BGN");
            Console.WriteLine($"Money for charity - {charity:F2} BGN");
        }
    }
}
