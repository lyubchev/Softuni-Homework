using System;

namespace _4_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
           string name = "";
           string bestPlayer = name;
           int goals = 0;
           int maxGoals = goals;
           while((name = Console.ReadLine()) != "END")
           {
               goals = int.Parse(Console.ReadLine());
               if(goals > maxGoals)
               {
                   maxGoals = goals;
                   bestPlayer = name;
               }
               if(maxGoals >= 10)
               {
                   Console.WriteLine($"{bestPlayer} is the best player!");
                   Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
                   return;
               }
           }
            Console.WriteLine($"{bestPlayer} is the best player!");
            if(maxGoals>=3)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
