using System;

namespace Pounds_to_Dollars {
    class Program {
        static void Main (string[] args) {
            const double britishPound = 1.31;
            double britishPounds = double.Parse (Console.ReadLine());
            double dollars = britishPounds * britishPound;
            Console.WriteLine ($"{dollars:F3}");
        }
    }
}