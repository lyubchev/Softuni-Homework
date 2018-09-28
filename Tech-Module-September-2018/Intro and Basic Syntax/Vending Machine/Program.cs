using System;
using System.Collections.Generic;

namespace Vending_Machine {
    class Program {
        static void Main (string[] args) {

            string input = Console.ReadLine ();
            decimal balance = 0.0m;

            while (input != "Start") {

                if (IsValidCoin (input)) {
                    balance += decimal.Parse (input);
                }
                input = Console.ReadLine ();
            }

            input = Console.ReadLine ();

            while (input != "End") {

                if (IsValidProduct (input)) {
                    if (balance < GetProductPrice (input)) {
                        Console.WriteLine ("Sorry, not enough money");
                        input = Console.ReadLine ();
                        continue;
                    }
                    balance -= GetProductPrice (input);
                    Console.WriteLine($"Purchased {input.ToLower()}");
                }
                input = Console.ReadLine ();
            }
            Console.WriteLine ($"Change: {balance:F2}");
        }

        static bool IsValidCoin (string coin) {
            List<string> validCoins = new List<string> (new string[] { "0.1", "0.2", "0.5", "1", "2" });

            if (!validCoins.Contains (coin)) {
                Console.WriteLine ($"Cannot accept {coin}");
                return false;
            }

            return true;
        }

        static bool IsValidProduct (string product) {
            List<string> validProducts = new List<string> (new string[] { "Nuts", "Water", "Crisps", "Soda", "Coke" });

            if (!validProducts.Contains (product)) {
                Console.WriteLine ($"Invalid product");
                return false;
            }

            return true;
        }

        static decimal GetProductPrice (string product) {
            Dictionary<string, decimal> products = new Dictionary<string, decimal> () { { "Nuts", 2.0m }, { "Water", 0.7m }, { "Crisps", 1.5m }, { "Soda", 0.8m }, { "Coke", 1.0m }};

            return products[product];
        }
    }
}