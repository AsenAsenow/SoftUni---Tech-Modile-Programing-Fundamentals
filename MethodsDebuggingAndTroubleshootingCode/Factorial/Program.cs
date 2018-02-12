using System;
using System.Numerics;


namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(CalculateFactorial(n));
        }

        static BigInteger CalculateFactorial(int n)
        {
            BigInteger fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            return fact;
        }
    }
}
