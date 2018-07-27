using System;

namespace Cat_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine())*1000.0;
            string command = Console.ReadLine();
            
            while (command != "Adopted")
            {
                food -= double.Parse(command);
                command = Console.ReadLine();
            }
            if(food >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {food} grams.");
            }
            else
            {
                food *= -1;
                Console.WriteLine($"Food is not enough. You need {food} grams more.");
            }
        }
    }
}
