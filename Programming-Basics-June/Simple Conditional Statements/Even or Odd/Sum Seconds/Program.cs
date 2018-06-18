using System;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int time1 = int.Parse(Console.ReadLine());
            int time2 = int.Parse(Console.ReadLine());
            int time3 = int.Parse(Console.ReadLine());
            int minutes = 0;
            int seconds = 0;
            seconds = time1 + time2 + time3;
            minutes = seconds / 60;
            seconds = seconds - minutes * 60;
            string secs = seconds < 10 ? "0" + seconds.ToString() : seconds.ToString();
            Console.WriteLine(minutes.ToString()+":"+secs);
        }
    }
}
