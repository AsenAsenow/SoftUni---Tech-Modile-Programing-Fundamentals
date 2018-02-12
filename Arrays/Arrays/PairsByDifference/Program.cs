using System;
using System.Linq;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int difference = int.Parse(Console.ReadLine());
            int pairs = 0;

            for (int i = 0; i < arrayInput.Length; i++)
            {
                for (int j = i+1; j < arrayInput.Length; j++)
                {
                    if (Math.Abs(arrayInput[i]-arrayInput[j])==difference)
                    {
                        pairs++;
                    }
                }
            }
            Console.WriteLine(pairs);
        }
    }
}
