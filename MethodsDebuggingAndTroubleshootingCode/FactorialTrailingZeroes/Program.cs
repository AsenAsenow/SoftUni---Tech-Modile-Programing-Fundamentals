using System;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = FactorialResult(n);
            int zero = TrailingZeroCount(factorial);
            Console.WriteLine(zero);
        }

        static int TrailingZeroCount(BigInteger num)
        {
            int zero = 0;
            bool hasZeroes = true;
            while (hasZeroes == true)
            {
                BigInteger digit = num % 10;
                num /= 10;
                if (digit == 0)
                {
                    zero++;
                }
                else
                {
                    hasZeroes = false;
                }
            }
            return zero;
        }

        static BigInteger FactorialResult(int n)
        {
            BigInteger sum = 0;

            if (n == 1)
            {
                return 1;
            }
            else
            {
                sum = FactorialResult(n - 1) * n;
                return sum;
            }
        }
    }
}
