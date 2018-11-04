using System;
using System.Linq;
using System.Collections.Generic;

namespace Quests_Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> quests = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();

            while (input != "Retire!")
            {
                string command = input.Split(" - ")[0];
                string quest = input.Split(" - ")[1];

                switch (command)
                {
                    case "Start":
                        if (!quests.Contains(quest))
                        {
                            quests.Add(quest);
                        }
                        break;
                    case "Complete":
                        if (quests.Contains(quest))
                        {
                            quests.Remove(quest);
                        }
                        break;
                    case "Side Quest":
                        if (quests.Contains(quest.Split(":")[0]))
                        {
                            int index = quests.IndexOf(quest.Split(":")[0]) + 1;
                            if (!quests.Contains(quest.Split(":")[1]))
                            {
                                quests.Insert(index, quest.Split(":")[1]);
                            }
                        }
                        break;
                    case "Renew":
                        if (quests.Contains(quest))
                        {
                            quests.Remove(quest);
                            quests.Add(quest);
                        }
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", quests));
        }
    }
}
