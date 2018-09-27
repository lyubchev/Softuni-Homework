using System;

namespace Vacation {
    class Program {
        static void Main (string[] args) {
            int groupSize = int.Parse (Console.ReadLine ());
            string groupType = Console.ReadLine ();
            string day = Console.ReadLine ();
            double pricePerPerson = 0;
            double total = 0;

            if (groupType == "Students") {
                if (day == "Friday") {
                    pricePerPerson = 8.45;
                } else if (day == "Saturday") {
                    pricePerPerson = 9.80;
                } else if (day == "Sunday") {
                    pricePerPerson = 10.46;
                }

                total = pricePerPerson * groupSize;
                if(groupSize >= 30) {
                    total *= 0.85;
                }
            }

            if (groupType == "Business") {
                if (day == "Friday") {
                    pricePerPerson = 10.90;
                } else if (day == "Saturday") {
                    pricePerPerson = 15.60;
                } else if (day == "Sunday") {
                    pricePerPerson = 16.00;
                }

                total = pricePerPerson * groupSize;
                if(groupSize >= 100) {
                    total -= 10 * pricePerPerson;
                }
            }

            if (groupType == "Regular") {
                if (day == "Friday") {
                    pricePerPerson = 15.00;
                } else if (day == "Saturday") {
                    pricePerPerson = 20.00;
                } else if (day == "Sunday") {
                    pricePerPerson = 22.50;
                }

                total = pricePerPerson * groupSize;
                if(groupSize >= 10 && groupSize <= 20) {
                    total *= 0.95;
                }
            }

            Console.WriteLine($"Total price: {total:F2}");
        }
    }
}