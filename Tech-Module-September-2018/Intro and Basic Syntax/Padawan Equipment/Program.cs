using System;

namespace Padawan_Equipment {
    class Program {
        static void Main (string[] args) {
            decimal balance = decimal.Parse (Console.ReadLine ());
            int studentsCount = int.Parse (Console.ReadLine ());
            decimal lightsaberPrice = decimal.Parse (Console.ReadLine ());
            decimal robePrice = decimal.Parse (Console.ReadLine ());
            decimal beltPrice = decimal.Parse (Console.ReadLine ());

            // Ivan Cho needs 10% more lightsabers, because sometimes they brake
            int lightsabersCount = (int) Math.Ceiling (1.1 * studentsCount);
            int robesCount = studentsCount;
            int beltsCount = studentsCount - (studentsCount / 6);

            decimal total = lightsabersCount * lightsaberPrice + robesCount * robePrice + beltsCount * beltPrice;

            if (total <= balance) {
                Console.WriteLine ($"The money is enough - it would cost {total:F2}lv.");
            } else {
                Console.WriteLine ($"Ivan Cho will need {(total - balance/*  */):F2}lv more.");
            }

        }
    }
}