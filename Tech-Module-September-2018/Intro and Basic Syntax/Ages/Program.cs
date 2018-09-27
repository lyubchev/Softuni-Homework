using System;

namespace Ages {
    class Program {
        static void Main (string[] args) {
            int age = int.Parse (Console.ReadLine ());

            if (age >= 0 && age <= 2) {
                Console.WriteLine ("baby");
                return;
            }

            if (age >= 3 && age <= 13) {
                Console.WriteLine ("child");
                return;
            }

            if (age >= 14 && age <= 19) {
                Console.WriteLine ("teenager");
                return;
            }

            if (age >= 20 && age <= 65) {
                Console.WriteLine ("adult");
                return;
            }

            if (age >= 66) {
                Console.WriteLine ("elder");
                return;
            }

        }
    }
}