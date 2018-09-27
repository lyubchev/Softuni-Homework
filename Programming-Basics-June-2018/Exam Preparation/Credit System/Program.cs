using System;

namespace Credit_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int courses = int.Parse(Console.ReadLine());
            
            double credits = 0;
            double avg = 0;
            double grade = 0;
            double percent = 0;
            for (int i = 0; i < courses; i++)
            {
                int course = int.Parse(Console.ReadLine());
                grade = course % 10;
                switch (grade)
                {
                    case 3:
                        percent=0.50;
                        break;
                    case 4:
                        percent=0.70;
                        break;
                    case 5:
                        percent=0.85;
                        break;
                    case 6:
                        percent=1.00;
                        break;
                    default:
                        percent = 0;
                        break;

                }
                course /= 10;
                credits += (course*percent);
                avg += grade;
            }
            avg /= courses;
            Console.WriteLine($"{credits:F2}");
            Console.WriteLine($"{avg:F2}");
        }
    }
}
