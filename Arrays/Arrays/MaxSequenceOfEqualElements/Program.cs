using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int counter = 0;
            int repeatIndex = 0;
            int countSec = 0;

            for (int index = 1; index < numbers.Length; index++)
            {
                if (numbers[index - 1] == numbers[index])
                {
                    counter++;
                    if (counter>countSec)
                    {
                        repeatIndex = index - counter;
                        countSec = counter;
                    }
                }
                else
                {
                    counter = 0;              
                }

            }
            for (int i = repeatIndex; i <= repeatIndex+countSec; i++)
            {
                Console.Write(numbers[i]+" ");
            }

        }
    }
}
