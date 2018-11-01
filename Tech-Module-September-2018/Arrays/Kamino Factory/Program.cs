using System;
using System.Linq;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int[] bestDNA = new int[dnaLength];
            int bestLength = 1;
            int bestStartIndex = -1;
            int bestSample = 0;
            int currentSample = 0;

            while (command != "Clone them!")
            {
                int currentLenght = 1;
                int currentStartIndex = -1;
                int currentSum = 0;
                currentSample++;

                int[] dna = command.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                bool wasFound = false;

                if (currentSample == 1)
                {
                    bestDNA = dna;
                    bestSample = currentSample;
                }
                for (int i = 0; i < dnaLength; i++)
                {
                    currentSum = dna.Sum();
                    if (dna[i] == 1)
                    {
                        currentStartIndex = !wasFound ? i : currentStartIndex;
                        currentLenght++;
                        wasFound = true;

                        if (currentLenght > bestLength)
                        {
                            bestDNA = dna;
                            bestLength = currentLenght;
                            bestStartIndex = currentStartIndex;
                            bestSample = currentSample;
                        }
                        else if (currentLenght == bestLength)
                        {
                            if (currentStartIndex < bestStartIndex || currentStartIndex > bestStartIndex)
                            {
                                bestDNA = dna;
                                bestStartIndex = currentStartIndex;
                                bestSample = currentSample;
                            }
                            else if (currentStartIndex == bestStartIndex)
                            {
                                if (dna.Sum() > bestDNA.Sum())
                                {
                                    bestDNA = dna;
                                    bestSample = currentSample;
                                }
                            }
                        }
                    }
                    else
                    {
                        currentLenght = 0;
                        currentStartIndex = 0;
                        wasFound = false;
                    }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestDNA.Sum()}.");
            Console.WriteLine(string.Join(" ", bestDNA));
        }
    }
}
