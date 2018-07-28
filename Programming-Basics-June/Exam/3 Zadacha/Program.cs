using System;

namespace _3_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
           string country = Console.ReadLine();
           string souvenir = Console.ReadLine();
           int amount = int.Parse(Console.ReadLine());
           double itemPrice = 0;
           switch (country)
           {
               case "Argentina":
                    if(souvenir == "flags")
                    {
                        itemPrice = 3.25;
                    }
                    else if (souvenir == "caps")
                    {
                        itemPrice = 7.20;
                    }
                    else if (souvenir == "posters")
                    {
                        itemPrice = 5.10;
                    }
                    else if (souvenir == "stickers")
                    {
                        itemPrice = 1.25;
                    }
                     else{
                        Console.WriteLine("Invalid stock!");
                        return;
                    }
                break;

                case "Brazil":
                    if(souvenir == "flags")
                    {
                        itemPrice = 4.20;
                    }
                    else if (souvenir == "caps")
                    {
                        itemPrice = 8.50;
                    }
                    else if (souvenir == "posters")
                    {
                        itemPrice = 5.35;
                    }
                    else if (souvenir == "stickers")
                    {
                        itemPrice = 1.20;
                    }
                     else{
                        Console.WriteLine("Invalid stock!");
                        return;
                    }
                break;

                case "Croatia":
                    if(souvenir == "flags")
                    {
                        itemPrice = 2.75;
                    }
                    else if (souvenir == "caps")
                    {
                        itemPrice = 6.90;
                    }
                    else if (souvenir == "posters")
                    {
                        itemPrice = 4.95;
                    }
                    else if (souvenir == "stickers")
                    {
                        itemPrice = 1.10;
                    }
                     else{
                        Console.WriteLine("Invalid stock!");
                        return;
                    }
                break;

                case "Denmark":
                    if(souvenir == "flags")
                    {
                        itemPrice = 3.10;
                    }
                    else if (souvenir == "caps")
                    {
                        itemPrice = 6.50;
                    }
                    else if (souvenir == "posters")
                    {
                        itemPrice = 4.80;
                    }
                    else if (souvenir == "stickers")
                    {
                        itemPrice = 0.90;
                    }
                    else{
                        Console.WriteLine("Invalid stock!");
                        return;
                    }
                break;
               default:
               Console.WriteLine("Invalid country!");
               return;
               break;
           }
            double total = itemPrice * amount;
            Console.WriteLine($"Pepi bought {amount} {souvenir} of {country} for {total:F2} lv.");
        }
    }
}
