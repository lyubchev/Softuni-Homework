using System;

namespace Name_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string nameWinner = name;
            int maxPoints = 0;
            int points = 0;
            while (name != "STOP")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    points += name[i];
                }
                if(points>maxPoints)
                {
                    maxPoints = points;
                    nameWinner = name;
                }
                points = 0;
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {nameWinner} - {maxPoints}!");
        }
    }
}
