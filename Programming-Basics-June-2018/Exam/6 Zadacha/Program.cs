using System;

namespace _6_Zadacha
{
    class Program
    {
        static void Main(string[] args)
        {
            int purvo_chislo_za_purvi_nomer = int.Parse(Console.ReadLine());
            int vtoro_chislo_za_purvi_nomer = int.Parse(Console.ReadLine());
            int purvo_chislo_za_vtori_nomer = int.Parse(Console.ReadLine());
            int vtoro_chislo_za_vtori_nomer = int.Parse(Console.ReadLine());

            int valid = 0;

            for (int i = purvo_chislo_za_purvi_nomer; i <= 8; i++)
            {
                for (int j = 9; j >= vtoro_chislo_za_purvi_nomer; j--)
                {
                    for (int k = purvo_chislo_za_vtori_nomer; k <= 8; k++)
                    {
                        for (int l = 9; l >= vtoro_chislo_za_vtori_nomer ; l--)
                        {
                            int num1 = int.Parse(i.ToString() + j.ToString());
                            int num2 = int.Parse(k.ToString() + l.ToString());

                            if(i % 2 == 0 && j % 2 != 0 && k % 2 == 0 && l % 2 != 0)
                            {
                                if(num1 != num2)
                                {
                                    Console.WriteLine($"{i}{j} - {k}{l}");
                                    valid++;
                                    if(valid == 6)
                                    {
                                        return;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                            }
                            else
                            {
                                continue;
                            }

                        }
                    }
                }
            }
        }
    }
}
