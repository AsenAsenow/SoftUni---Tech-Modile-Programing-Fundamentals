using System;
using System.Linq;

namespace IndexOfLetters
{
    class Program
    {
        private static int count;

        static void Main(string[] args)
        {
            char[] arr = new char[26];

            int i = 0;
            char ch = 'a';
            for (; i < arr.Length; i++, ch++)
            {
                arr[i] = ch;
            }

            string latters = Console.ReadLine();
            for (i = 0; i < latters.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (latters[i] == arr[j])
                    {
                        Console.WriteLine(latters[i] + " -> " + j);
                    }
                }
            }
        }
    }
}
