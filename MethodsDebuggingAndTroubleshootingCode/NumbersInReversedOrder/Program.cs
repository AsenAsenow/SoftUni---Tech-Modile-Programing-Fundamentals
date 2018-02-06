using System;

namespace NumbersInReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseNumber(input));
            
        }

        static string ReverseNumber(string input)
        {
            string reverseNumber = "";
            for (int i = input.Length-1; i >= 0; i--)
            {
                reverseNumber += input[i];
            }
            return reverseNumber;

        }
    }
}
