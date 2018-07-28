using System;

namespace _5_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            int matches = int.Parse(Console.ReadLine());
            int penalties = 0;
            int additionalTime = 0;
            double avg = 0;
            int total = 0;
            for (int i = 0; i < matches; i++)
            {
                int match = int.Parse(Console.ReadLine());
                total += match;
                if(match > 90 && match <= 120)
                {
                    additionalTime++;
                }
                if(match > 120)
                {
                    penalties++;
                }
                avg += match;
            }
            avg /= matches;
            Console.WriteLine($"{team} has played {total} minutes. Average minutes per game: {avg:F2}");
            Console.WriteLine($"Games with penalties: {penalties}");
            Console.WriteLine($"Games with additional time: {additionalTime}");
        }
    }
}
