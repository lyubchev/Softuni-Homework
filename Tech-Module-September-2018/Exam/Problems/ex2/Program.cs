using System;
using System.Collections.Generic;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "end")
            {
                string artist = input.Split(":")[0];
                string song = input.Split(":")[1];

                if (IsValidArtist(artist) && IsValidSong(song))
                {
                    string encryptedArtist = Encrypt(artist.Length, artist);
                    string encryptedSong = Encrypt(artist.Length, song);
                    string result = $"{encryptedArtist}@{encryptedSong}";
                    Console.WriteLine($"Successful encryption: {encryptedArtist}@{encryptedSong}");
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
                input = Console.ReadLine();
            }
        }

        private static bool IsValidArtist(string artist)
        {
            if (artist[0].ToString() == artist[0].ToString().ToUpper())
            {
                for (int i = 1; i < artist.Length; i++)
                {
                    char letter = artist[i];
                    if (letter.ToString() == @"'" || letter.ToString() == @" ")
                    {
                        continue;
                    }

                    if (letter.ToString() != letter.ToString().ToLower())
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsValidSong(string song)
        {
            if (song == song.ToUpper() || song.Contains(" ") && song.Contains(@"'") && song == song.ToUpper())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string Encrypt(int key, string input)
        {
            string encryptedInput = "";
            foreach (var letter in input)
            {
                if (letter.ToString() == " " || letter.ToString() == @"'")
                {
                    encryptedInput += letter;
                    continue;
                }
                char encryptedLetter = ' ';
                if (letter >= 65 && letter <= 90)
                {
                    if (letter + key > 90)
                    {
                        int laino = 90 - letter;
                        int newKey = key - laino;
                        encryptedLetter = (char)(64 + newKey);
                    }
                    else
                    {
                        encryptedLetter = (char)(letter + key);
                    }
                }
                else if (letter >= 97 && letter <= 122)
                {
                    if (letter + key > 122)
                    {
                        int laino = 122 - letter;
                        int newKey = key - laino;
                        encryptedLetter = (char)(96 + newKey);
                    }
                    else
                    {
                        encryptedLetter = (char)(letter + key);
                    }
                }

                encryptedInput += encryptedLetter;
            }
            return encryptedInput;
        }
    }
}
