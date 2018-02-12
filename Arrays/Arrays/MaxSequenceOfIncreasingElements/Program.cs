using System;
using System.Linq;

namespace MaxSequenceOfIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            int longestSeqLength = 1;
            int longestSeqStart = 0;
            int currentSeqLength = 1;
            int currentSeqStart = 0;

            for (int i = 1; i < arrayInput.Length; i++)
            {
                if (arrayInput[i] > arrayInput[i - 1])
                {
                    currentSeqLength++;

                    if (currentSeqLength > longestSeqLength)
                    {
                        longestSeqLength = currentSeqLength;
                        longestSeqStart = currentSeqStart;
                    }
                }
                else
                {
                    currentSeqLength = 1;
                    currentSeqStart = i;
                }
            }

            for (int i = longestSeqStart; i < longestSeqStart + longestSeqLength; i++)
            {
                Console.Write(arrayInput[i] + " ");
            }

        }
    }
}
