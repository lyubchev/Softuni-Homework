using System;

namespace Speed_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double speed = double.Parse(Console.ReadLine());
            // MEME CONDITION
            Console.WriteLine(speed <= 10 ? "slow" : speed > 10 && speed <= 50 ? "average" : speed > 50 && speed <= 150 ? "fast" : speed > 150 && speed <= 1000 ? "ultra fast" : "extremely fast");
        }
    }
}
