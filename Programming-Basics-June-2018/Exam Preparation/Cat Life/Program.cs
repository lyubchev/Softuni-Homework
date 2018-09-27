using System;

namespace Cat_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string breed = Console.ReadLine();
            string sex = Console.ReadLine();
            int months = 0;
            switch (breed)
            {
                case "British Shorthair":
                    months = 13;
                    break;
                case "Siamese":
                    months = 15;
                    break;    
                case "Persian":
                    months = 14;
                    break;  
                case "Ragdoll":
                    months = 16;
                    break;
                case "American Shorthair":
                    months = 12;
                    break;
                case "Siberian":
                    months = 11;
                    break;
                default:
                Console.WriteLine($"{breed} is invalid cat!");
                return;
                break;
            }
            if(sex == "f") months++;
            months *= 12;
            months = Convert.ToInt32(Math.Floor(months/6.0));
            Console.WriteLine($"{months} cat months");
        }
    }
}
