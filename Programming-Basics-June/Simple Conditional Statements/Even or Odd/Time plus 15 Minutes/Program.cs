using System;

namespace Time_plus_15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] time = new int[2];
            // time[0] - hours, time[1] - minutes
            time[0] = int.Parse(Console.ReadLine());
            time[1] = int.Parse(Console.ReadLine());
            time[1] += 15;
            if (time[1] > 59)
            {
                time[1] = time[1]-60;
                time[0]++;
            }
            if (time[0] > 23)
                time[0] = 0;
            string timeIn15Minutes = time[0].ToString() + ":" + time[1].ToString().PadLeft(2, '0');
            Console.WriteLine(timeIn15Minutes);
        }
    }
}
