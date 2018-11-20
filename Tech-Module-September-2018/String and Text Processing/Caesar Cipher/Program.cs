using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encryptedText = Encrypt(input);
            Console.WriteLine(encryptedText);
        }

        static string Encrypt(string input)
        {
            string encryptedText = "";
            for (int i = 0; i < input.Length; i++)
            {
                encryptedText += ((char)(input[i] + 3)).ToString();
            }

            return encryptedText;
        }
    }
}
