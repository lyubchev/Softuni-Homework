using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "End")
            {
                string operation = command.Split()[0];

                switch (operation)
                {
                    case "Add":
                        int number = int.Parse(command.Split()[1]);
                        numbers.Add(number);
                        break;
                    case "Insert":
                        int index = int.Parse(command.Split()[2]);
                        number = int.Parse(command.Split()[1]);
                        if (index >= 0 && index <= numbers.Count() - 1)
                        {
                            numbers.Insert(index, number);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        index = int.Parse(command.Split()[1]);
                        if (index >= 0 && index <= numbers.Count() - 1)
                        {
                            numbers.RemoveAt(index);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;

                    case "Shift":

                        if (command.StartsWith("Shift right"))
                        {
                            int count = int.Parse(command.Split()[2]);
                            for (int i = 0; i < count; i++)
                            {
                                int temp = numbers[numbers.Count() - 1];
                                numbers.RemoveAt(numbers.Count() - 1);
                                numbers.Insert(0, temp);
                            }
                        }
                        else
                        {
                            int count = int.Parse(command.Split()[2]);
                            for (int i = 0; i < count; i++)
                            {
                                int temp = numbers[0];
                                numbers.RemoveAt(0);
                                numbers.Add(temp);
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
