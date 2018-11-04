using System;

namespace Party_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int partySize = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int balance = 0;
            int coins = 0;

            for (int i = 1; i <= days; i++)
            {
                balance += 50;
                
                if (i % 10 == 0)
                {
                    partySize -= 2;
                }

                if (i % 15 == 0)
                {
                    partySize += 5;
                }

                balance -= partySize * 2;

                if (i % 3 == 0)
                {
                    balance -= partySize * 3;
                }

                if (i % 5 == 0)
                {
                    balance += partySize * 20;
                    if (i % 3 == 0)
                    {
                        balance -= partySize * 2;
                    }
                }
            }
            coins = Convert.ToInt32(balance / partySize);

            Console.WriteLine($"{partySize} companions received {coins} coins each.");
        }
    }
}