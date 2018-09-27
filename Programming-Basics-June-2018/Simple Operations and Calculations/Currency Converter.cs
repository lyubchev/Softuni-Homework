using System;

class Currency_Converter
{
    static void Main(string[] args)
    {
      // OBVIOUSLY COPIED CODE (HAD NO TIME BECAUSE IN CLASS)
        double num = double.Parse(Console.ReadLine());
        var first = Console.ReadLine().ToLower();//ToLower -прави текста в малки букви
        var second = Console.ReadLine().ToLower();

        if (first == "usd")
        {
            if (second == "bgn")
            {
                Console.WriteLine("{0}", Math.Round(num * 1.79549, 2));
            }
            else if (second == "eur")
            {
                Console.WriteLine("{0}", Math.Round(num * 0.91801, 2));
            }
            else if (second == "gbp")
            {
                Console.WriteLine("{0}", Math.Round(num * 0.70854, 2));
            }

        }

        if (first == "bgn")
        {
            if (second == "usd")
            {
                Console.WriteLine("{0}", Math.Round(num / 1.79549, 2));
            }
            else if (second == "eur")
            {
                Console.WriteLine("{0}", Math.Round(num / 1.95583, 2));
            }
            else if (second == "gbp")
            {
                Console.WriteLine("{0}", Math.Round(num / 2.53405, 2));
            }
        }

        if (first == "eur")
        {
            if (second == "bgn")
            {
                Console.WriteLine("{0}", Math.Round(num * 2.53405, 2));
            }
            else if (second == "usd")
            {
                Console.WriteLine("{0}", Math.Round(num * 1.08930, 2));
            }
            else if (second == "gbp")
            {
                Console.WriteLine("{0}", Math.Round(num * 0.77181, 2));
            }
        }
        if (first == "gbp")
            if (second == "bgn")
            {
                Console.WriteLine("{0}", Math.Round(num * 0.39462, 2));
            }
            else if (second == "usd")
            {
                Console.WriteLine("{0}", Math.Round(num * 2.53405 / 1.79549, 2));//Тука беше разликата.
            }
            else if (second == "eur")
            {
                Console.WriteLine("{0}", Math.Round(num * 0.77181, 2));
            }
    }
}