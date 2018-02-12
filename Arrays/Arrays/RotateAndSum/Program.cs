using System;
using System.Linq;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayInput = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotation = int.Parse(Console.ReadLine());
            int[] arr = new int[arrayInput.Length];
            for (int i = 0; i < rotation; i++)
            {
                int[] rotated = new int[arrayInput.Length];
                rotated[0] = arrayInput[arrayInput.Length - 1];
                for (int j = 1; j < rotated.Length; j++)
                {
                    rotated[j] = arrayInput[j - 1];
                }

                for (int j = 0; j < arr.Length; j++)
                {
                    arr[j] += rotated[j];
                }

                arrayInput = rotated;
            }

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
