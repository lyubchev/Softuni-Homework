using System;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
           char start = Console.ReadLine()[0];
           char end = Console.ReadLine()[0];
           char ignore = Console.ReadLine()[0];
           string combination = "";
           int valid =0;

           for (int i = (int)start; i <= (int)end; i++)
           {
               for (int j = (int)start; j <= (int)end; j++)
               {
                   for (int k = (int)start; k <= (int)end; k++)
                    {
                        combination = ((char)i).ToString() + ((char)j).ToString() + ((char)k).ToString();
                        if((char)i == ignore || (char)j == ignore || (char)k == ignore)
                        {
                            continue;
                        }
                        Console.Write(combination + " ");
                        valid++;
                    }
               }
           } 
           Console.WriteLine(valid);
        }
    }
}
