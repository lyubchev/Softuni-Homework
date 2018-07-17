using System;

namespace Matrix {
    class Program {
        static void Main (string[] args) {
            int a = int.Parse (Console.ReadLine ());
            int b = int.Parse (Console.ReadLine ());
            int c = int.Parse (Console.ReadLine ());
            int d = int.Parse (Console.ReadLine ());

            for (int first = a; first <= b; first++) 
            {
                for (int second = a; second <= b; second++) 
                {
                    for (int third = c; third <= d; third++)
                    {
                         for (int fourth = c; fourth <= d; fourth++)
                        {
                            if(first != second && third != fourth)
                            {
                                if(first + fourth == second + third)
                                {
                                  Console.WriteLine($"{first}{second}");  
                                  Console.WriteLine($"{third}{fourth}");
                                  Console.WriteLine();
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}