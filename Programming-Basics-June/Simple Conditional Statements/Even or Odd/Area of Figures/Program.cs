using System;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            switch (figure)
            {
                case "square":
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine(a * a);
                    break;
                case "rectangle":
                    a = double.Parse(Console.ReadLine());
                    double b = double.Parse(Console.ReadLine());
                    Console.WriteLine(a * b);
                    break;
                case "circle":
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine(Math.PI * a * a);
                    break;
                case "triangle":
                    a = double.Parse(Console.ReadLine());
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine((a * b) / 2);
                    break;
                default:
                    break;
            }
        }
    }
}
