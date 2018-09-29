using System;

namespace Triangle_of_Numbers {
    class Program {
        static void Main (string[] args) {
            int n = int.Parse (Console.ReadLine ());
            if (n >= 1 && n <= 20) {

                for (int i = 1; i <= n; i++) {

                    for (int j = 0; j < i; j++) {
                        Console.Write (i + " ");
                    }
                    Console.WriteLine ();
                }
            }
        }
    }
}