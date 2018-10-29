using System;
using System.Collections.Generic;
using System.Linq;

namespace House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                string guest = command.Split()[0];
                if (!command.Contains(" not "))
                {
                    if (guests.Contains(guest))
                    {
                        Console.WriteLine($"{guest} is already in the list!");
                        continue;
                    }
                    guests.Add(guest);
                    continue;
                }


                if (command.Contains(" not "))
                {
                    if (guests.Contains(guest))
                    {
                        guests.Remove(guest);
                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not in the list!");
                    }

                    continue;
                }
            }
            Console.WriteLine(string.Join("\n", guests));
        }
    }
}
