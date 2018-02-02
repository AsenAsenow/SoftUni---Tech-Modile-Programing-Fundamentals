using System;

namespace TestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());


            int sum = 0;
            int combinations = 0;

            for (int i = firstNumber; i >= 1; i--)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    string result = $"{i} {j};";
                    combinations++;
                    
                    sum += 3 * (i * j);
                    if (sum >= max)
                    {
                        Console.WriteLine($"{combinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {max}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
