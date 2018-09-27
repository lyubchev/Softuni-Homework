using System;

namespace _2_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            double tshirtPrice = double.Parse(Console.ReadLine());
            double shortsPrice = tshirtPrice * 0.75;
            double socksPrice = shortsPrice * 0.2;
            double bootsPrice = (tshirtPrice + shortsPrice) * 2;
            double minCost = double.Parse(Console.ReadLine());
            double total = tshirtPrice + shortsPrice + bootsPrice + socksPrice;
            total *= 0.85;
            if(total >= minCost)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {total:F2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {(minCost - total):F2} lv. more.");
            }
        }
    }
}
