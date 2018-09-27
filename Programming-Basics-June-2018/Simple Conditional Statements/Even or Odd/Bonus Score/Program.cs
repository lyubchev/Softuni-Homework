using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            double score = double.Parse(Console.ReadLine());
            double bonus = 0;
            bonus = score % 2 == 0 ? 1 : bonus;
            bonus = score % 10 == 5 ? 2 : bonus;
            if (score<=100)
            {
                bonus += 5;
            }
            if (score>100 && score <=1000)
            {
                bonus += 0.2 * score;
            }
            if(score>1000)
            {
                bonus += 0.1 * score;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(bonus+score);
        }
    }
}
