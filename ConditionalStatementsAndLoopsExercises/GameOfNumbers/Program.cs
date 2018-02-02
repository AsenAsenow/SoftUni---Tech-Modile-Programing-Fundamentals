using System;

namespace GameOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int numOne = 0;
            int numTwo = 0;
            int counterCombinations = 0;

            for (numOne = n; numOne <= m; numOne++)
            {
                for (numTwo = n; numTwo <= m; numTwo++)
                {
                 
                    counterCombinations += 1;

                    if (numTwo + numOne == magicNumber)
                    {
                        Console.WriteLine($"Number found! {numTwo} + {numOne} = {magicNumber}");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{counterCombinations} combinations - neither equals {magicNumber}");





        }
    }
}
