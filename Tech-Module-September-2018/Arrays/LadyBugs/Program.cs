using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];
            string command = Console.ReadLine();

            field = InitializeField(initialIndexes, field);

            while (command != "end")
            {
                int ladybug = int.Parse(command.Split()[0]);
                int flyLength = int.Parse(command.Split()[2]);
                string direction = command.Split()[1];
                flyLength = direction == "right" ? flyLength : flyLength * -1;

                if ((ladybug >= fieldSize || ladybug < 0) || field[ladybug] == 0)
                {
                    command = Console.ReadLine();
                    continue;
                }

                field[ladybug] = 0;
                ladybug += flyLength;

                while ((ladybug < fieldSize && ladybug >= 0))
                {
                    if (field[ladybug] == 0)
                    {
                        field[ladybug] = 1;
                        break;
                    }
                    ladybug += flyLength;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", field));
        }

        static int[] InitializeField(int[] initialIndexes, int[] initialField)
        {
            for (int i = 0; i < initialIndexes.Length; i++)
            {
                if (initialIndexes[i] >= 0 && initialIndexes[i] < initialField.Length)
                {
                    initialField[initialIndexes[i]] = 1;
                }
            }

            return initialField;
        }
    }
}
