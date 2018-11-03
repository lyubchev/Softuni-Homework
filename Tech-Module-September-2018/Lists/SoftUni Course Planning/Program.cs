using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialSchedule = Console.ReadLine().Split(", ").ToList();
            string command = Console.ReadLine();

            while (command != "course start")
            {
                string[] commandElements = command.Split(":");
                string operation = commandElements[0];
                string lessonTitle = commandElements[1];
                switch (operation)
                {
                    case "Add":
                        if (!initialSchedule.Contains(lessonTitle))
                        {
                            initialSchedule.Add(lessonTitle);
                        }
                        break;
                    case "Insert":
                        if (!initialSchedule.Contains(lessonTitle))
                        {
                            initialSchedule.Insert(int.Parse(commandElements[2]), lessonTitle);
                        }
                        break;
                    case "Remove":
                        if (initialSchedule.Contains(lessonTitle))
                        {
                            if (initialSchedule.Contains($"{lessonTitle}-Exercise"))
                            {
                                initialSchedule.Remove($"{lessonTitle}-Exercise");
                            }
                            initialSchedule.Remove(lessonTitle);
                        }
                        break;
                    case "Swap":
                        if (initialSchedule.Contains(lessonTitle) && initialSchedule.Contains(commandElements[2]))
                        {
                            int firstIndex = initialSchedule.IndexOf(lessonTitle);
                            int secondIndex = initialSchedule.IndexOf(commandElements[2]);

                            initialSchedule.Remove(lessonTitle);
                            initialSchedule.Insert(secondIndex, lessonTitle);

                            initialSchedule.Remove(commandElements[2]);
                            initialSchedule.Insert(firstIndex, commandElements[2]);

                            if (initialSchedule.Contains($"{lessonTitle}-Exercise"))
                            {
                                int exerciseIndex = initialSchedule.IndexOf(lessonTitle) + 1;
                                initialSchedule.Remove($"{lessonTitle}-Exercise");
                                initialSchedule.Insert(exerciseIndex, $"{lessonTitle}-Exercise");
                            }

                            if (initialSchedule.Contains($"{commandElements[2]}-Exercise"))
                            {
                                int exerciseIndex = initialSchedule.IndexOf(commandElements[2]) + 1;
                                initialSchedule.Remove($"{commandElements[2]}-Exercise");
                                initialSchedule.Insert(exerciseIndex, $"{commandElements[2]}-Exercise");
                            }
                        }
                        break;
                    case "Exercise":
                        if (!initialSchedule.Contains($"{lessonTitle}-Exercise") && initialSchedule.Contains(lessonTitle))
                        {
                            int exerciseIndex = initialSchedule.IndexOf(lessonTitle) + 1;
                            initialSchedule.Insert(exerciseIndex, $"{lessonTitle}-Exercise");
                        }

                        if (!initialSchedule.Contains(lessonTitle))
                        {
                            initialSchedule.Add(lessonTitle);
                            initialSchedule.Add($"{lessonTitle}-Exercise");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            for (int i = 0; i <= initialSchedule.Count() - 1; i++)
            {
                int index = i + 1;
                Console.WriteLine($"{index}.{initialSchedule[i]}");
            }
        }
    }
}
