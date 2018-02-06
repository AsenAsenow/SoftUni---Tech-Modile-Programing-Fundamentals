using System;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(getMax(numberOne, numberTwo), numberThree));
        }

        static int getMax(int a, int b)
        {
            int max= Math.Max(a, b);
            return max;
        }
    }
}
