using System;

namespace Travelling {
    class Program {
        static void Main (string[] args) {

            while (true) {
                string goal = Console.ReadLine ();
                if (goal == "End") break;
                double minBudget = double.Parse (Console.ReadLine ());
                double saved = 0;
                while (saved < minBudget) {
                    saved += double.Parse (Console.ReadLine ());
                }
                Console.WriteLine ($"Going to {goal}!");
            }
        }
    }
}