using System;
using System.Collections.Generic;
using System.Linq;

namespace Advertisement_Message
{
    class Message
    {
        private readonly string[] Phrases =
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };

        private readonly string[] Events =
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };
        private readonly string[] Authors =
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Annie",
            "Eva"
        };
        private readonly string[] Cities =
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };

        public string GenerateMessage()
        {
            Random rnd = new Random();

            string msg = "";
            string phraseMsg = Phrases[rnd.Next(0, Phrases.Length)];
            string eventMsg = Events[rnd.Next(0, Events.Length)];
            string authorMsg = Authors[rnd.Next(0, Authors.Length)];
            string cityMsg = Cities[rnd.Next(0, Cities.Length)];
            msg = $"{phraseMsg} {eventMsg} {authorMsg} - {cityMsg}";
            return msg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message();
            Console.WriteLine(msg.GenerateMessage());
        }
    }
}

