using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int storeys = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            
           for (int storey = storeys; storey > 0 ; storey--)
           {
               if(storey==storeys)
               {
                   for (int num = 0; num < rooms; num++)
                   {
                       Console.Write("L{0}{1} ",storey,num);
                   }
                   Console.WriteLine();
                   continue;
               }
               if(storey%2==0)
               {
                   for (int num = 0; num < rooms; num++)
                   {
                       Console.Write("O{0}{1} ",storey,num);
                   }
                   Console.WriteLine();
               }
               else
               {
                    for (int num = 0; num < rooms; num++)
                   {
                       Console.Write("A{0}{1} ",storey,num);
                   }
                   Console.WriteLine();
               }
           }
        }
    }
}
