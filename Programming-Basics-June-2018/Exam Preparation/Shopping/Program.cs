using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double choco = double.Parse(Console.ReadLine()) * 0.65;
            double milk = double.Parse(Console.ReadLine()) * 2.70;
            double mandarins = ((int)(0.65 * (choco / 0.65))) * 0.20;
            double total = Math.Round(choco + milk + mandarins,2);
            if(total <= balance)
            {
                System.Console.WriteLine($"You got this, {(balance - total):F2} money left!");
            }
            else
            {
                System.Console.WriteLine($"Not enough money, you need {(total - balance):F2} more!");
            }
        }
    }
}
