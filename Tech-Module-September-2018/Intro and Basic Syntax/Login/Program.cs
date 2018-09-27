using System;

namespace Login {
    class Program {
        static void Main (string[] args) {

            string username = Console.ReadLine ();
            string password = GeneratePassword (username);
            string input = Console.ReadLine ();
            int badLoginAttempts = 0;
            while (input != password) {
                badLoginAttempts++;
                if (badLoginAttempts >= 4) {
                    break;
                }
                Console.WriteLine ("Incorrect password. Try again.");
                input = Console.ReadLine ();
            }
            Console.WriteLine (badLoginAttempts <= 3 ? $"User {username} logged in." : $"User {username} blocked!");
        }

        static string GeneratePassword (string username) {

            System.Text.StringBuilder password = new System.Text.StringBuilder ();
            for (int i = 0; i < username.Length; i++) {
                password.Append (username[username.Length - i - 1]);
            }
            return password.ToString ();
        }
    }
}