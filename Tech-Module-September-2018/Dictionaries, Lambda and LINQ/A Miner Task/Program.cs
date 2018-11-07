using System;
using System.Linq;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var resources = new Dictionary<string, int>();
            string resource = "";
            bool isResource = true;

            while (input != "stop")
            {
                if (isResource)
                {
                    resource = input;
                }
                else
                {
                    if (resources.ContainsKey(resource))
                    {
                        resources[resource] += int.Parse(input);
                    } else {
                        resources[resource] = int.Parse(input);
                    }
                }

                input = Console.ReadLine();
                isResource = !isResource;
            }

            foreach (var item in resources)
            {
                
            Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
