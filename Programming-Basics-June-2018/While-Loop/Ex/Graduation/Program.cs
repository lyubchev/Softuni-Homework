using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double avg = 0;
            double grade = 6;
            int currentGrade = 1;
            while (currentGrade<=12)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade >= 4.0) avg += grade;
                else currentGrade--;
                currentGrade++;
            }
            avg /= 12.0;
            if (avg >= 4.0)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avg:F2}");
            }
        }
    }
}
