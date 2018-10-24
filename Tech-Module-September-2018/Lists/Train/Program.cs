using System;
using System.Collections.Generic;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPassengers = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            while (command != "end")
            {
                int passengers = command.StartsWith("Add ") ? int.Parse(command.Substring(4)) : int.Parse(command);
                if (command.StartsWith("Add "))
                {
                    wagons.Add(passengers);
                }
                else
                {
                    foreach (var wagon in wagons.ToList())
                    {
                        if (wagon + passengers <= maxPassengers)
                        {
                            wagons[wagons.IndexOf(wagon)] += passengers;
                            break;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
