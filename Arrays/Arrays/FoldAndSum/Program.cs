using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            int k = arrayInput.Length / 4;
            int[] upperRow = new int[k * 2];
            int[] lowerRow = new int[k * 2];

            for (int i = 0; i < k; i++)
            {
                upperRow[i] = arrayInput[k - i - 1];
                upperRow[upperRow.Length - i - 1] = arrayInput[arrayInput.Length - k + i];
                lowerRow[2 * i] = arrayInput[2 * i + k];
                lowerRow[2 * i + 1] = arrayInput[2 * i + k + 1];
            }

            int[] result = new int[k * 2];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = upperRow[i] + lowerRow[i];
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
