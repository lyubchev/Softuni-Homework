using System;
using System.Collections.Generic;
using System.Linq;


namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine().Trim();

            while (command != "end")
            {
                int num = int.Parse(command.Split()[1]);
                int index = command.Split().Length == 3 ? int.Parse(command.Split()[2]) : -1;
                if (command.StartsWith("Insert"))
                {
                    if (index >= 0)
                    {
                        list.Insert(index, num);
                    }
                }
                else
                {
                    list.RemoveAll(x => x == num);
                }

                command = Console.ReadLine().Trim();
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}