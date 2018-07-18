using System;

namespace Cookie_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int batches = int.Parse(Console.ReadLine());
            for (int i = 1; i <= batches; i++)
            {
                string ingredient = Console.ReadLine();
                bool eggs = false;
                bool flour = false;
                bool sugar = false;
                while (true)
                {
                    if(ingredient == "eggs")
                        eggs = true;
                    else if(ingredient == "flour")
                        flour = true;
                    else if(ingredient == "sugar")
                        sugar = true;
                    else if(ingredient == "Bake!")
                    {
                        if(eggs && sugar && flour)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The batter should contain flour, eggs and sugar!");
                        }
                    }
                    ingredient = Console.ReadLine();
                }
                Console.WriteLine($"Baking batch number {i}...");
            }
        }
    }
}
