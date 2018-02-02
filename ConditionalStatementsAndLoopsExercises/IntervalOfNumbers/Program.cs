using System;

namespace IntervalOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int end = Math.Max(firstNumber, secondNumber);
            int start = Math.Min(firstNumber, secondNumber);
            for (int i = start; i <=end; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
