using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] wordsFirstRow = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();
            char[] wordsSecondRow = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(char.Parse)
                .ToArray();


            if (wordsFirstRow[0]==wordsSecondRow[0])
            {
                if (wordsFirstRow.Length<wordsSecondRow.Length)
                {
                    for (int i = 0; i < wordsFirstRow.Length; i++)
                    {
                        Console.Write(wordsFirstRow[i]);
                    }
                    Console.WriteLine();
                    for (int i = 0; i < wordsSecondRow.Length; i++)
                    {
                        Console.Write(wordsSecondRow[i]);
                    }
                    Console.WriteLine();
                    for (int i = 0; i < wordsFirstRow.Length; i++)
                    {
                        Console.Write(wordsFirstRow[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    for (int i = 0; i < wordsSecondRow.Length; i++)
                    {
                        Console.Write(wordsSecondRow[i]);
                    }
                    Console.WriteLine();
                    for (int i = 0; i < wordsFirstRow.Length; i++)
                    {
                        Console.Write(wordsFirstRow[i]);
                    }
                    Console.WriteLine();
                }
            }
            else if (wordsFirstRow[0] < wordsSecondRow[0])
            {
                for (int i = 0; i < wordsFirstRow.Length; i++)
                {
                    Console.Write(wordsFirstRow[i]);
                }
                Console.WriteLine();
                for (int i = 0; i < wordsSecondRow.Length; i++)
                {
                    Console.Write(wordsSecondRow[i]);
                }
                Console.WriteLine();
            }
            else if (wordsFirstRow[0] >wordsSecondRow[0])
            {
                for (int i = 0; i < wordsSecondRow.Length; i++)
                {
                    Console.Write(wordsSecondRow[i]); 
                }
                Console.WriteLine();
                for (int i = 0; i < wordsFirstRow.Length; i++)
                {
                    Console.Write(wordsFirstRow[i]);
                }
                Console.WriteLine();
            }


        }      
    }
}
