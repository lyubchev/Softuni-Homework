using System;

namespace Graduationpt2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double avg = 0;
            double grade = 6;
            int currentGrade = 1;
            int skusan = 0;
            while (currentGrade <= 12)
            {
                grade = double.Parse(Console.ReadLine());
                if (grade >= 4.0) avg += grade;
                else { currentGrade--; skusan++; }
                currentGrade++;
                if (skusan > 1)
                {
                    Console.WriteLine($"{name} has been excluded at {currentGrade} grade");
                    break;
                }
            }
            avg /= 12.0;
            if (avg >= 4.0 && skusan<=1)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avg:F2}");
            }
        }
    }
}
