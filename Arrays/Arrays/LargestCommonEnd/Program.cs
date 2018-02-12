using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsFirstRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] wordsSecondRow = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            Console.WriteLine(Math.Max(ScannArrayLeftToRight(wordsFirstRow, wordsSecondRow), ScannArraysRightToLeft(wordsFirstRow, wordsSecondRow)));
        }

        static int ScannArrayLeftToRight(string[] first, string[] second)
        {
            int lenghtArrays = Math.Min(first.Length, second.Length);
            int counterEquals = 0;

            for (int i = 0; i < lenghtArrays; i++)
            {
                if (first[i].Equals(second[i]))
                {
                    counterEquals++;
                }
            }
            return counterEquals;
        }

        static int ScannArraysRightToLeft(string[] first, string[] second)
        {
            Array.Reverse(first);
            Array.Reverse(second);
            int lenghtArrays = Math.Min(first.Length, second.Length);
            int counterEquals = 0;
            for (int i = 0; i < lenghtArrays; i++)
            {
                if (first[i].Equals(second[i]))
                {
                    counterEquals++;
                }
            }
            return counterEquals;
        }
    }
}
