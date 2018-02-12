using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] arrayInput = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(ushort.Parse)
               .ToArray();
            int[] count = new int[ushort.MaxValue];

            foreach (ushort num in arrayInput)
            {
                count[num]++;
            }

            int maxValue = count.Max();

            for (int i = 0; i < arrayInput.Length; i++)
            {
                if (count[arrayInput[i]] == maxValue)
                {
                    Console.WriteLine(arrayInput[i]);
                    return;
                }
            }
        }
    }
}
