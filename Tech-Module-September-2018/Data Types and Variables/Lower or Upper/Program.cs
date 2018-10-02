using System;

namespace Lower_or_Upper {
    class Program {
        static void Main (string[] args) {
            string input = Console.ReadLine ();
            if (input.ToUpper () == input) {
                Console.WriteLine ("upper-case");
            } else {
                Console.WriteLine ("lower-case");
            }
        }
    }
}