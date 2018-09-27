using System;

namespace Days_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();
            DateTime date_1 = new DateTime(int.Parse(date1.Split('-')[2]), int.Parse(date1.Split('-')[1]), int.Parse(date1.Split('-')[0]));
            DateTime date_2 = new DateTime(int.Parse(date2.Split('-')[2]), int.Parse(date2.Split('-')[1]), int.Parse(date2.Split('-')[0]));
            int odd = 0, even = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % 2 == 0) even++;
                else odd++;
            }
            date_1 =date_1.AddDays(even);
            date_2 =date_2.AddDays(odd);
            int sum = date_1.Day + date_2.Day;
            Console.WriteLine(sum);
        }
    }
}
