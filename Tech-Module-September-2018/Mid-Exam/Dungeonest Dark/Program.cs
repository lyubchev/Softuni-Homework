using System;
using System.Linq;
using System.Collections.Generic;

namespace Dungeonest_Dark
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> rooms = Console.ReadLine().Split("|").ToList();

            int playerHealth = 100;
            int playerCoins = 0;
            int bestRoom = 1;
            foreach (var room in rooms)
            {
                string item = room.Split()[0];
                int number = int.Parse(room.Split()[1]);
                string monster = "";
                if (item == "potion" || item == "chest")
                {
                    if (item == "potion")
                    {
                        if (playerHealth <= 100)
                        {
                            if (playerHealth + number > 100)
                            {
                                number = 100 - playerHealth;
                            }
                            playerHealth += number;
                            Console.WriteLine($"You healed for {number} hp.");
                        }
                        else
                        {

                            Console.WriteLine($"You healed for {number} hp.");
                        }
                        Console.WriteLine($"Current health: {playerHealth} hp.");
                    }
                    else
                    {
                        playerCoins += number;
                        Console.WriteLine($"You found {number} coins.");
                    }

                }
                else
                {
                    monster = item;
                    playerHealth -= number;
                    if (playerHealth < 1)
                    {
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {bestRoom}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                }
                bestRoom++;
            }

            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Coins: {playerCoins}");
            Console.WriteLine($"Health: {playerHealth}");
        }
    }
}