using System;

namespace Reversed_Chars {
    class Program {
        static void Main (string[] args) {
            string a = Console.ReadLine ();
            a += Console.ReadLine ();
            a += Console.ReadLine ();
            a = ReverseString (a);
            Console.WriteLine (a);
        }

        static string ReverseString (string a) {
            System.Text.StringBuilder reversed = new System.Text.StringBuilder ();
            for (int i = 0; i < a.Length; i++) {
                reversed.Append (a[a.Length - i - 1] + " ");
            }
            return reversed.ToString ();
        }
    }
}